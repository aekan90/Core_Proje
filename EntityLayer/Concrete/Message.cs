﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // ANA SAYFADAKİ CONTACT SEKMESİNİN MESAJ GÖNDERME KISMI
    public class Message
    {
        [Key]  // ID için key atamsı yapıyoruz. ID birincil anahtar olması için
        public int MessageId { get; set; }
        public string Name { get; set; } 
        public string Mail { get; set; } 
        public string Content { get; set; } 
        public DateTime Date { get; set; } 
        public bool Status { get; set; }  // mesaj okundu-okunmadı

    }
}
