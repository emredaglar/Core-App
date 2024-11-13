using System.ComponentModel.DataAnnotations;

namespace Core_App.Areas.Writer.Models
{
    public class UserRegisterViewModel

    {
        public string Name { get; set; }
        public string SurName{ get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
        public string UserName { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage ="Şifreyi Tekrar Girin")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string Mail { get; set; }
    }
}
