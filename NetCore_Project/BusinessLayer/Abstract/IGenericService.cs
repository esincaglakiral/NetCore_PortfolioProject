using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);  //burada metotların başına T getirilir Dataaccesstekinden farklı olarak
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetlist();
        T TGetByID(int id);
        List<T> TGetListByFilter();

    }
}
