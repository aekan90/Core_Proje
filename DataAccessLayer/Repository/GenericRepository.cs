using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    // T : Entitilerimiz : About , Contact , 
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        // 
        public void Delete(T T)
        {
            Context c1= new Context();
            // bu yapı ile alt satırın farkı ne?
            using var c = new Context(); // her yerde kullanacaz
            // c.EntityFramework mettolarına erişebilriz
            c.Remove(T);
            c.SaveChanges(); // Db ye yansıtması için 
        }
        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);// Find: EF metodu
        }
        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList(); // ToList: EF metodu
        }
        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t); // AddList: EF metodu
            c.SaveChanges();
        }
        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t); // Update: EF metodu : .net core ile geldi
            c.SaveChanges();
        }
    }
}
