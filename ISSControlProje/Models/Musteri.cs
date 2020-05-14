using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ISSControlProje.Models
{
    public class Musteri
    {
        public int MusteriId { get; set; }

        
        public string Tc { get; set; }

        [Display(Name = "Müşteri İsmi")]
        [Required]
        public string Ad { get; set; }

        [Display(Name = "Müşteri Adresi")];
        [Required]
        public string Adres { get; set; }

        [Display(Name = "Müşteri Telefonu")];
        [Required]
        public string Telefon { get; set; }

        [Display(Name = "Taahüt Miktarı")];
        [Required]
        public string Taahut { get; set; }

        public int? PaketId { get; set; }

        public virtual Paket Paket { get; set; }
    }
}