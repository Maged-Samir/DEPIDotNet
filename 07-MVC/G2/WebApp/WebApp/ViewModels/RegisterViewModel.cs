using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="this is reqired Filed")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "this is reqired Filed")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "this is reqired Filed")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "this is reqired Filed")]
        [Compare("Password",ErrorMessage ="Password Not identical")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }



    }
}
