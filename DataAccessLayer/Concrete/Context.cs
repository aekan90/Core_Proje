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
    public class Context : DbContext // DB Setleri kullanabilmek için 
    {
        // tabloları property olarak çağıracağız.

        // Bağlantı Stringi Ayarlıyoruz. Bizim bağlantı adresimizi tutacak
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DESKTOP-OA1OLIM;database=CoreProjeDB;integrated security=true");
        }

        // Entity katmanındaki sınıfları tek tek burada çağırmalıyız.
        public int MyProperty { get; set; }
    }
}
