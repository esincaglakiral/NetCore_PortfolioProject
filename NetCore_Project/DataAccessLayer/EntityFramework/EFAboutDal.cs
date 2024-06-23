using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFAboutDal : GenericRepository<About>, IAboutDal  //GenericRepository den miras alır (T parametresi yerine About Entitysi), ve IAboutDal interface'inden miras alır. Interface'i de miras olarak yazmamızın sebebi ise eklenecek olan yeni metotların implement edilebilmesi ve bu classta kullanabilmek
    {
    }
}
