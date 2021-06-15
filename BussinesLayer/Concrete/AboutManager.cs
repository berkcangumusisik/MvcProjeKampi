using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;

namespace BussinesLayer.Concrete
{   
    public class AboutManager : IAboutService
        {
            IAboutDal _aboutDal;

            public AboutManager(IAboutDal aboutDal)
            {
                _aboutDal = aboutDal;
            }

            public void AboutAdd(About about)
            {
                _aboutDal.Insert(about);
            }

            public void AboutDelete(About about)
            {
                _aboutDal.Delete(about);
            }

            public void AboutUpdate(About about)
            {
                _aboutDal.Update(about);
            }

            public About GetByID(int id)
            {
                return _aboutDal.Get(x => x.AboutId == id);
            }

            public List<About> GetList()
            {
                return _aboutDal.List();
            }

            public List<About> GetListByHeadingID(int id)
            {
                throw new NotImplementedException();

            }
        }

    }

