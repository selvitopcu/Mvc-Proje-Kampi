using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //Tden hangi tablo deperi gelirse
    {
        List<T> List();

        void Insert(T p); //T sınıfından gelen p nesnesi
        void Update(T p);
        void Delete(T p);
       // List<T> List(Exception)

            //Burada eklediğimiz her şey diğer abstractlarda eklenecek
    }
}
