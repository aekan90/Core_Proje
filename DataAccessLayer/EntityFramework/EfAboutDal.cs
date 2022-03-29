using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;


namespace DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
        // bu classın içeriğini görmek için GenericRepository<About> classına bak

        // EfAboutDal içi boş gibi görünse de değil
        // İçerisinde GenericRepoasitory classı içerisinden gelen
        // veri tabanımıza erişmemizi sağlayan metotlarımız gizli olarak mevcuttur
        // GenericRepsitory<About> şeklinde kalıtım aldığımızdan dolayı
        // bu classdan new ile yeni bir nesne ürettiğimizde GenericRepository<About>
        // nesnemiz hazır olacak ve db mize erişmek üzere EF crud metotlarına sahip olacaz
        // refadi. dediğimizde bütün EF metotlarına erişebileceğiz.

        
    }
}
