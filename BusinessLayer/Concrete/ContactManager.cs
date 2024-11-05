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
    public class ContactManager:IContactService
    {
        IContactDal _ContactDal; 

        public ContactManager(IContactDal ContactDal)
        {
            _ContactDal = ContactDal;
        }

        public void TAdd(Contact t)
        {
            _ContactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _ContactDal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            return _ContactDal.GetById(id);
        }

        public List<Contact> TGetList()
        {
            return _ContactDal.GetAll();
        }


        public void TUpdate(Contact t)
        {
            _ContactDal.Update(t);
        }
    }
}
