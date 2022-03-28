using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService  // BusinessLayer.Abstract.IAboutService : IGenericService<About>
    {
        // Concrete klasörü içindeki classları 'Manager' olarak adlandıracağız
        // Abstract klasörü içindekileri 'Service' olarak adlandırmıştık.

        IAboutDal _AboutDal;

        // Constructor metodumuz ile ilgili atamalarımızı kullanabileceğiz
        public AboutManager(IAboutDal aboutDal) 
        {
            _AboutDal = aboutDal; // bu eşleştirmeyi yaptıktan sonra IGenericDal metotlarımıza erişebiliriz artık
        }

        public void TAdd(About t)
        {
            _AboutDal.Insert(t); // DataAccessLayer da tanımladığımız DataAccessLayer.Abstract.IGenericDal ortak CRUD metotlarımız
        }

        public void TDelete(About t)
        {
            _AboutDal.Delete(t); // IGenericDal metotlarımıza erişebiliriz
        }

        public About TGetById(int id)
        {
            return _AboutDal.GetById(id);
        }

        public List<About> TGetList()
        {
            return _AboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _AboutDal.Update(t);
        }

    }
}
