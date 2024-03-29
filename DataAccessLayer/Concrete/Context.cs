﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    // Context Classı
    // 1-) DB yapılandırmamız içindeki bağlantı stringini tutar.
    // 2-) DB 'ye yansıtılacak olan tabloları tutar             
    public class Context : IdentityDbContext<WriterUser, WriterRole, int>// DB Setleri kullanabilmek için 
    // WriterUser daki 3 propertimizin AspNetUsers tablosuna sütun eklenebilmesi için migratin öncesi buraya parametre olarak vermeliyiz
    {
        // tabloları property olarak çağıracağız.

        // Bağlam (tdk): Deste,İlişki örgüsü, Bağlantısı, kontext
        // Context(bağlam) Stringi Ayarlıyoruz. Bizim bağlantı adresimizi tutacak
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=CoreProjeDB;integrated security=true");
        }

        // Entity katmanındaki sınıfları tek tek burada çağırmalıyız.
        // public DbSet<EntityName> TableNames {get;set}
        // Class ve Propertyleri --> Tablo ve Sütunlarına dönüşecek
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<ToDoList> Test1 { get; set; }
    }
}
