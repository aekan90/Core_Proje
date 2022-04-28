using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Identity;

namespace EntityLayer.Concrete
{
    public class WriterUser : IdentityUser<int>
    {// bu 3 property identity ile gelen AspNetUser tablosunda yok
        // migration ile AspNetUser tablosuna sütun ekleyecez olacak.
        // Context mirasına bak
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
    }
}
