using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService : IGenericService<About>
    {
        // CRUD işlemlerini generic olarak IGenericService de yazdığımız için
        // burada ve Bu interfaceden inherite alan bütün classlar
        // Ortak CRUD işlemlerine erişim hakkına sahip olacaklar
        // geri döndim 11.08.2022
    }
}
