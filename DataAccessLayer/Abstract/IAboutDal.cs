using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAboutDal : IGenericDal<About>
    {
        //// "About" Entitisi için bir Interface oluşturduk ve CRUD işlemlerini tanımladı.
        //void Insert(About P);
        //void Update(About P);
        //void Delete(About P);
        //List<About> GetList(); 
    }
}
