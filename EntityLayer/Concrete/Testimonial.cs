﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // ANA SAYFADAKİ REFERANSLAR-TESTİMONİAL KISMI
    public class Testimonial
    {
        [Key]  // ID için key atamsı yapıyoruz. ID birincil anahtar olması için
        public int TestimonialId { get; set; }
        public string ClientName { get; set; }
        public string Company { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
