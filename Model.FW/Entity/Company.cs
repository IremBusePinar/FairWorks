using Core.FW.CoreEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Entity
{
     public class Company:BaseEntity
    {
        [Required(ErrorMessage ="Şirket adı bilgisi boş geçilemez!"),Display(Name ="Şirket Adı")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage ="Sektör bilgisi boş geçilemez!"),Display(Name ="Sektör")]
        public string Sector { get; set; }
        [Display(Name ="Adres")]
        public string Adress { get; set; }
        [Display(Name = "Şehir")]
        public string City { get; set; }
        [Display(Name = "Ülke")]
        public string Country { get; set; }

        public virtual List<Fair> Fair { get; set; }
        public virtual List<FairParticipant> FairParticipants { get; set; }
        
    }
}
