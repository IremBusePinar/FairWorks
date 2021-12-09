using Core.FW.CoreEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Entity
{
   public class CompanyUser:BaseEntity
    {
        [Display(Name ="Şirket Adı")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage ="Ad alanı boş geçilemez!"),Display(Name ="Ad")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş geçilemez!"), Display(Name = "Soyad")]
        public string LastName { get; set; }
        [Display(Name ="Ünvan")]
        public string Title { get; set; }
        [Display(Name = "Mail Adresi"),Required(ErrorMessage ="Lütfen mail adresinizi giriniz.")]
        public string EMail { get; set; }
        [Display(Name = "Kullanıcı Adı"), Required(ErrorMessage = "Lütfen kullanıcı adını giriniz.")]
        public string UserName { get; set; }
        [Display(Name = "Şifre"),Required(ErrorMessage ="Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }
        [Display(Name = "Telfon Numarası")]
        public string PhoneNumber { get; set; }


    }
}
