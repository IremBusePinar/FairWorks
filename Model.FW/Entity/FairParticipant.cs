using Core.FW.CoreEntity;
using Core.FW.CoreEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.FW.Entity
{
    public class FairParticipant:BaseEntity
    {
        [Display(Name ="Katılımcı Firma Yetkilisi")]
        public string SalesPerson { get; set; }
        [Display(Name = "Görüşme tarihi"),DataType(DataType.Date)]
        
        public DateTime MeetingDate{ get; set; }
        [Display(Name = "Görüşme yapılan Firma çalışanı")]
        public CompanyUser User { get; set; }
        [Display(Name = "Firma Adı")]
        public Sector CompanyName { get; set; }
        [Display(Name = "Firma profili")]
        public CompanyProfile CompanyProfile { get; set; }
        [Display(Name = "Firmanın ilgilendiği fuarlar")]
        public Fair FairName { get; set; }
        [Display(Name = "Firmanın ilgilendiği salon")]
        public Salloon SalloonName { get; set; }
        [Display(Name = "Ekstra Notlar")]
        public string ExtraNotes { get; set; }
        [Display(Name = "Teklif tarihi"), DataType(DataType.Date)]
        public DateTime OfferDate { get; set; }
        [Display(Name = "Teklifin son geçerlilik tarihi"), DataType(DataType.Date)]
        public DateTime LastOfferDate { get; set; }

        [Display(Name = "Salon Numarası")]
        public Salloon SalloonNumber { get; set; }
        [Display(Name = "Stand Numarası")]
        public Stand StandNumber { get; set; }
        [Display(Name = "İstenilen metrekare")]
        public Stand M2 { get; set; }
        [Display(Name = "Sözleşme Tarihi"), DataType(DataType.Date)]
        public DateTime ContractDate { get; set; }
        [Display(Name = "Sözleşme tipi")]
        public ContractType ContractType { get; set; }
        [Display(Name = "Stand Tipi")]
        public StandType StandType { get; set; }
        [Display(Name = "Metrekare fiyatı")]
        public decimal M2Price { get; set; }
        [Display(Name = "İndirim Oranı")]
        public decimal DiscountRate { get; set; }
        [Display(Name = "Toplam Fiyat")]
        public decimal Price { get; set; }

        public virtual List<Fair>  Fair { get; set; }

        public virtual CompanyUser CompanyUser { get; set; }
        public virtual Company Company { get; set; }
        public virtual Salloon Salloon { get; set; }
        public virtual Stand Stand { get; set; }
        public virtual List<Sector> Sector { get; set; }















    }
}
