using System.ComponentModel.DataAnnotations;

namespace Core_App.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}
