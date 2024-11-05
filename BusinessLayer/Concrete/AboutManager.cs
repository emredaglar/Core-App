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
	public class AboutManager : IAboutService
	{
		

		IAboutDal _AboutDal;

		
		public AboutManager(IAboutDal aboutDal) 
		{
			_AboutDal = aboutDal;
		}

		public void TAdd(About t)
		{
			_AboutDal.Insert(t); 
		}

		public void TDelete(About t)
		{
			_AboutDal.Delete(t); // IGenericDal metotlarımıza erişebiliriz
		}

		public About TGetByID(int id)
		{
			return _AboutDal.GetById(id);
		}

		public List<About> TGetList()
		{
			return _AboutDal.GetAll();
		}

		public void TUpdate(About t)
		{
			_AboutDal.Update(t);
		}
	}
}
