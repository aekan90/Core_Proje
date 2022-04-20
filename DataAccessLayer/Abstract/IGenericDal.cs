using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // Generic İnterfaceimizi oluşturduk ki bu metotları
    // her interface içerisinde yazmayalım
    // İçerisine generic metotlarımızı yazdık içlerini
    // concreate classlarda dolduracağız
    public interface IGenericDal<T> where T : class
    {
        // bu metotlar concrate içinde doldurulacak
        void Insert(T P);  //void Insert(Skill P); 
        void Update(T P); //void Update(Skill P);
        void Delete(T P); //void Delete(Skill P);
        List<T> GetList(); //List<Skill> GetList();
        T GetById(int id);   //SkillRefName.GetById(3);
    }
}
