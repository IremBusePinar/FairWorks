using Core.FW.CoreEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Entity
{
    public class Visitor:BaseEntity
    {
        [Display(Name = "Ziyaretçi Adı"),Required(ErrorMessage ="Lütfen adınızı giriniz.")]
        public string FirstName { get; set; }
        [Display(Name = "Ziyaretçi Soyadı"), Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        public string LastName { get; set; }
        [Display(Name = "Çalıştığı Şirket Adı ")]
        public string CompanyName { get; set; }
        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Mail Adresi")]
        public string MailAdress { get; set; }
        [Display(Name = "Meslek")]
        public string Occupation { get; set; }


    }
}
