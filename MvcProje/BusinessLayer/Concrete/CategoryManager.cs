using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo=new GenericRepository<Category> ();
        //Her bir işlem için methodlar tanımladım.
        public List<Category> GetAllBL()
        {
            return repo.List();
        }
        public void CatehoryAddBL(Category p)
        {
            if (p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>= 50)
            {
                //HHata Mesajı

            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
