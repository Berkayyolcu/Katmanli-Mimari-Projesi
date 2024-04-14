using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz !!")]
        public string UserName  { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz !!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz !!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz !!")]
        [Compare("Password",ErrorMessage ="Şifreler Uyumlu Değil !!")]
        public string ConfirmPassword { get; set; }
    }
}
