using Newtonsoft.Json;

namespace Trivister.API.ViewModel;

public class ForgotPasswordViewModel
{
    public string Token { get; set; }
    public string NewPassword { get; set; }
    public string Email { get; set; }
    [JsonIgnore]
    public string TokenExpiryTime { get; set; }
}