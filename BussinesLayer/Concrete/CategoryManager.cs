using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.Concrecte.Repostories;
using EntityLayer.Concrete;

namespace BussinesLayer.Concrete
{
    public class CategoryManager
    {
        private GenericRepository<Category> repo = new GenericRepository<Category>();
        public List<Category> GetAllBL()
        {
            return repo.List();
        }
        public void CategoryAddBl(Category p)
        {
            if(p.CategoryName == ""|| p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
            {
                //hata mesajı

            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
