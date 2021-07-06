using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BussinesLayer.Abstract
{
    public interface IImageFileService
    {
        List<ImageFile> GetList();
        void Add(ImageFile imageFile);
    }
}
