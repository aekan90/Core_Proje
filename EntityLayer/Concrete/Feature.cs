using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // ANA SAYFADAKİ açılışta en üst karşılama kısmı 
    public class Feature
    {
        [Key]  // ID için key atamsı yapıyoruz. ID birincil anahtar olması için
        public int FeatureID { get; set; }
        public string Header { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
