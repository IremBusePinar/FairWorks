using Core.FW.CoreEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Entity
{
   public class Salloon: BaseEntity
    {
        [Display(Name ="Salon Adı"),Required(ErrorMessage ="Salon adı boş geçilemez!")]
        public string SalloonName { get; set; }
        [Display(Name ="Hangi sektörün kullanımında?")]
        public string WhichSector { get; set; }
        [Display(Name ="Stand Numarası")]
        public int StandNumber { get; set; }

        public List<Stand> Stand { get; set; }

    }
}
