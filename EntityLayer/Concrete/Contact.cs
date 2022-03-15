﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // ANA SAYFADAKİ CONTACT SEKMESİNİN İLETİŞİM BİLGİLERİ KISMI
    public class Contact
    {
        [Key]  // ID için key atamsı yapıyoruz. ID birincil anahtar olması için
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
