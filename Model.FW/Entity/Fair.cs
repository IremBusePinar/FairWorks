using Core.FW.CoreEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Entity
{
     public class Fair: BaseEntity
    {
        [Required(ErrorMessage ="Fuar ismi alanı boş geçilemez!"),Display(Name ="Fuar İsmi")]
        public string FairName { get; set; }
        [Display(Name ="Sektör")]
        public Sector Sector { get; set; }
        [Display(Name = "Fuar Başlangıç Tarihi"), Required(ErrorMessage = "Lütfen fuar başlangıç tarihini giriniz."), DataType(DataType.Date)]
        public DateTime FirstDay { get; set; }
        [Display(Name = "Fuar Bitiş Tarihi"),Required(ErrorMessage ="Lütfen fuar bitiş tarihini giriniz."), DataType(DataType.Date)]
        public DateTime LastDay { get; set; }
        [Display(Name = "Salon Adı")]
        public Salloon SalloonName { get; set; }
        [Display(Name = "Katılımcı Sayısı")]
        public int TheNumberOfParticipant { get; set; }




        public virtual List<Company> Company { get; set; }

        public virtual List<Salloon> Salloon { get; set; }
        public virtual List<FairParticipant> FairParticipants{ get; set; }
    }
}
