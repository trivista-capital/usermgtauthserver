using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Serilog;
using Serilog.Context;
using Trivister.ApplicationServices.Exceptions;
using Trivister.Common.Model;

namespace Trivister.API.Filters;

    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private IWebHostEnvironment _environment;
        private ILogger<ErrorHandlingMiddleware> Logger { get; set; }
        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger, IWebHostEnvironment environment)
        {
            _next = next;
            this.Logger = logger;
            _environment = environment;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }
        
        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = HttpStatusCode.InternalServerError;
            var result = string.Empty;
            switch (exception)
            {
                case ApplicationServices.Exceptions.ValidationException validationException:
                    code = HttpStatusCode.BadRequest;
                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = (int)code;
                    string[] errorArray = validationException.Failures.SelectMany(x => x.Value).ToArray();
                    var error = string.Join(";", errorArray);
                    result = JsonConvert.SerializeObject(ErrorResult.Fail(error));
                    this.Logger.LogInformation($"An error occured.......{result}");
                    this.Logger.LogInformation("==================================================================================");
                    break;
                case BadRequestException badRequestException:
                    code = HttpStatusCode.BadRequest;
                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = (int)code;
                    result = JsonConvert.SerializeObject(ErrorResult.Fail(string.IsNullOrEmpty(badRequestException.Message)?"An error occured please contact Trivister support.": badRequestException.Message));
                    this.Logger.LogInformation(result);
                    this.Logger.LogInformation("==================================================================================");
                    break;
                case NotFoundException entityNotFoundException:
                    code = HttpStatusCode.NotFound;
                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = (int)code;
                    result = JsonConvert.SerializeObject(ErrorResult.Fail(string.IsNullOrEmpty(entityNotFoundException.Message)?"Entity not found. Please refine your search criteria and try again.": entityNotFoundException.Message));
                    this.Logger.LogInformation(result);
                    this.Logger.LogInformation("==================================================================================");
                    break;
                case Exception generalException:
                    code = HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    context.Response.StatusCode = (int)code;
                    result = JsonConvert.SerializeObject(ErrorResult.Fail("An error occured"));
                    this.Logger.LogError(generalException, generalException.Message);
                    this.Logger.LogInformation("==================================================================================");
                    break;
                default:
                    break;
            }
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            if (string.IsNullOrEmpty(result))
            {
                if (!_environment.IsProduction())
                {
                   
                    result = JsonConvert.SerializeObject(
                        ErrorResult.Fail("An error occured. Please contact Trivister support", exception), Formatting.Indented , 
                        new JsonSerializerSettings(){ReferenceLoopHandling = ReferenceLoopHandling.Ignore});

                }
                else
                {
                    result = JsonConvert.SerializeObject(
                        ErrorResult.Fail("An error occured. Please contact Trivister support"));
                }
               
                this.Logger.LogInformation($"An error occured.......{JsonConvert.SerializeObject(exception, Formatting.Indented, new JsonSerializerSettings() {ReferenceLoopHandling = ReferenceLoopHandling.Ignore})}");
                this.Logger.LogInformation("==================================================================================");
            }
            return context.Response.WriteAsync(result);
        }
    }
    
    public static class CustomExceptionHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }