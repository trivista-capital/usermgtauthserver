using System.ComponentModel.DataAnnotations;

namespace Trivister.API.ViewModel;

public class RegisterViewModel
{
    public string Username { get; set; }
    [Required(ErrorMessage = "Username is required")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Username is required")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Username is required")]
    public string LastName { get; set; }
    public string Phone { get; set; }
}