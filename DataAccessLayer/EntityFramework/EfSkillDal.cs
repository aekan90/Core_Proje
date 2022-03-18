using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfSkillDal : GenericRepository<Skill>, ISkillDal
    {
        // IAboutDal Neden Kullanıldı?
        // ilerde CRUD işlemleri dışında başka işlem gerekirse
        // ve bu işlem sadece Skill entitisine ait olursa
        // bu işlemin imzasını ISkillDal da atılacak
        // içeriği burada doldurulacak
    }
}
