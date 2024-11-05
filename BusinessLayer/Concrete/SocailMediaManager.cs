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
    public class SocailMediaManager : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocailMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TAdd(SocailMedia t)
        {
            _socialMediaDal.Insert(t);
        }

        public void TDelete(SocailMedia t)
        {
            _socialMediaDal.Delete(t);
        }

        public SocailMedia TGetByID(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public List<SocailMedia> TGetList()
        {
            return _socialMediaDal.GetAll();
        }

        public void TUpdate(SocailMedia t)
        {
            _socialMediaDal.Update(t);
        }
    }
}
