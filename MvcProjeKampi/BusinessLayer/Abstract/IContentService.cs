using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByWriter(int id);
        List<Content> GetListByHeadingID(int id); //ID'ye göre bütün listeyi döndürür.
        void ContentAdd(Content content);
        Content GetByID(int id); //tek değer döndürür.
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
