using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // ANA SAYFADAKİ SKİLL SEKMESİ, MYSKİLL KISMI
    public class Skill
    {
        [Key]  // ID için key atamsı yapıyoruz. ID birincil anahtar olması için
        public int SkillId { get; set; } 
        public string Title { get; set; }
        public string Value { get; set; }
    }
}
