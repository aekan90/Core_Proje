using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        // Bu servisler Business Tarafında CRUD operasyonları için gerekli olan
        // metotların çağrılmadan önce imzasını taşıyacak
        // Ek olarak da başka imzalar da gerekebilir.

        // CRUD işlemlerini generic olarak IGenericService de yazdığımız için
        // Bu interfaceden inherite alan bütün classlar ve Interface'ler
        // bu metotlara erişim hakkına sahip olacaklar

        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetById(int id);

    }
}
