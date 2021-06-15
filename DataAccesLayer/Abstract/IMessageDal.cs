using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccesLayer.Abstract
{
    public interface IMessageDal : IRepository<Message>
    {
    }
}
