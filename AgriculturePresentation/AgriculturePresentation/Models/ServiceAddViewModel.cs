using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Başlık boş geçilemez")]
        public string Title { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama boş geçilemez")]
        public string Description { get; set; }

        [Display(Name = "Icon Adı")]
        [Required(ErrorMessage = "Resim boş geçilemez")]
        public string Icon { get; set; }
    }
}
