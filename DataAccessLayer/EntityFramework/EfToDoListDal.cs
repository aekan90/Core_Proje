using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfToDoListDal : GenericRepository<ToDoList>, IToDoListDal
    {

        public List<ToDoList> Top5ToDoList()
        {
            List<ToDoList> list = new List<ToDoList>();
           // list = this.GetList<ToDoList>(); 
            return list;
        }


    }
}
