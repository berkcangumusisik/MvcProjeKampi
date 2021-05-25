using DataAccesLayer.Abstract;
using DataAccesLayer.Concrecte.Repostories;
using EntityLayer.Concrete;

namespace DataAccesLayer.EntityFramework
{
    public class EfCategoryDal: GenericRepository<Category>, ICategoryDal
    {

    }
}
