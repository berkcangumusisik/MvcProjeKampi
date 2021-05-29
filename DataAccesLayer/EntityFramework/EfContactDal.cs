using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrecte.Repostories;
using EntityLayer.Concrete;

namespace DataAccesLayer.EntityFramework
{
    public class EfContactDal: GenericRepository<Contact>, IContactDal
    {
    }
}
