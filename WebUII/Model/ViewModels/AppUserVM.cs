using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUII.Model.ViewModels
{
    public class AppUserVM
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez!"),Display(Name ="Kullanıcı Adı")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "E-Mail alanı boş geçilemez!"), Display(Name = "Mail Adresi")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Parola alanı boş geçilemez!"), Display(Name = "Parola")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Şifreler aynı değil!")]
        public string ConfirmPassword { get; set; }

    }
}