using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BussinesLayer.Abstract
{
    public interface IAboutService
    { 
            List<About> GetList();
            List<About> GetListByHeadingID(int id);
            void AboutAdd(About about);
            About GetByID(int id);
            void AboutDelete(About about);
            void AboutUpdate(About about);
       
    }
}
