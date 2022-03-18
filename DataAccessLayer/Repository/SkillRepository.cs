using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    // DB ye erişecez artık
    // GenericRepository classımız bu tip classların şablonudur
    class SkillRepository : IGenericDal<Skill>
    {
        public void Delete(Skill P)
        {
            throw new NotImplementedException();
        }

        public Skill GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Skill> GetList()
        {
            throw new NotImplementedException();
        }

        public void Insert(Skill P)
        {
            throw new NotImplementedException();
        }

        public void Update(Skill P)
        {
            throw new NotImplementedException();
        }
    }
}
