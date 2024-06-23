using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _userDal;

        public WriterUserManager(IWriterUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TAdd(WriterUser t)
        {
            _userDal.Insert(t);
        }

        public void TDelete(WriterUser t)
        {
            _userDal.Delete(t);
        }

        public WriterUser TGetByID(int id)
        {
            return _userDal.GetByID(id);
        }

        public List<WriterUser> TGetlist()
        {
            return _userDal.GetList();
        }

        public List<WriterUser> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterUser t)
        {
            _userDal.Update(t);
        }
    }
}
