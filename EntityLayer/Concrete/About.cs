﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // ANA SAYFADAKİ ABOUT SEKMESİ
    public class About
    {
        [Key] // ID için key atamsı yapıyoruz. ID birincil anahtar olması için
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Age { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
    }
}
