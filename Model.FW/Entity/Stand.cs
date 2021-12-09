using Core.FW.CoreEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Entity
{
     public class Stand:BaseEntity
    {
        [Display(Name ="Stand Numarası")]
        public int StandNumber { get; set; }
        [Display(Name = "Metrekare")]
        public int M2 { get; set; }
        [Display(Name = "Metrekare Fiyatı")]
        public decimal M2Price { get; set; }

        public virtual Salloon Salloon { get; set; }
    }
}
