using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class //Interface miras alındığında o interface içerisindeki metotlar mutlaka implement edilmelidit.
    {
        public void Delete(T t)
        {
            using var c = new Context(); //using, oluşturduğumuz nesneyi kullandıktan sonra bellekte tutmaz, bu da performans açısından önemlidir.
            c.Remove(t);
            c.SaveChanges(); // yapılan işlemin veritabanına yansıması için
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id); //Find(id) ile id'den gelen değeri bulacaktır. Set<T>() ise T'den gelen değer oluyor.
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
