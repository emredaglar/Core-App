using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager:IServiceService
    {
        IServiceDal _ServiceDal;
        public ServiceManager(IServiceDal servicedal)
        {
            _ServiceDal = servicedal;
        }

        public void TAdd(Service t)
        {
            _ServiceDal.Insert(t); 
        }

        public void TDelete(Service t)
        {
            _ServiceDal.Delete(t);
        }

        public Service TGetByID(int id)
        {
            return _ServiceDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _ServiceDal.GetAll();
        }
        public void TUpdate(Service t)
        {
            _ServiceDal.Update(t);
        }
    }
}
