using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ISkillDal : IGenericDal<Skill>
    {
        
        
        // "Skill" Entitisi için bir IGenericDal oluşturduk 
        // CRUD işlemlerini IGenericDal içerisinde tanımladı.
        
        // Bu metotlar ortak olarak IGenericDal içerisinde
        //void Insert(Skill P);
        //void Update(Skill P);
        //void Delete(Skill P);
        //List<Skill> GetList();
    }
}
