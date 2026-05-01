using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "this is reqired Filed")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "this is reqired Filed")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
    }
}
