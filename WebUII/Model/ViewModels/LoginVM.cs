using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUII.Model.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Kullanıcı adı girilmesi zorunludur!"),Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre girilmesi zorunludur!"),Display(Name ="Parola")]
        public string Password { get; set; }

    }
}