using Core.FW.CoreEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Entity
{
     public class Sector:BaseEntity
    {
        [Required(ErrorMessage ="Sektör adı alanı boş geçilemez!"),Display(Name ="Sektör Adı")]
        public string  SectorName { get; set; }
        public virtual List<Company> Companies { get; set; }
        public virtual List<Fair> Fair { get; set; }
        public virtual List<FairParticipant> FairParticipants { get; set; }
    }
}
  
