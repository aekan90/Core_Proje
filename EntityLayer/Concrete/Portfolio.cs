using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // ANA SAYFADAKİ BAŞLIK, KARŞILAMA KISMI
    public class Portfolio
    {
        [Key]  // ID için key atamsı yapıyoruz. ID birincil anahtar olması için
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string SmallImageUrl { get; set; }
    }
}
