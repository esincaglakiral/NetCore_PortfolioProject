using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService : IGenericService<About> // IGenericService<T> den miras alır (T= About entitysi)
    {
    }
}
