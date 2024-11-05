using BusinessLayer.Abstract;
using DataAccessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PortfolioManager:IPortfolioService
    {
        //tekrar bak
        EfPortfolioDal _efPortfolioDal = new EfPortfolioDal();

        public PortfolioManager(EfPortfolioDal efPortfolioDal)
        {
            _efPortfolioDal = efPortfolioDal;
        }

        public void TAdd(Portfolio t)
        {
            _efPortfolioDal.Update(t);
        }

        public void TDelete(Portfolio t)
        {
            _efPortfolioDal.Delete(t);
        }

        public Portfolio TGetByID(int id)
        {
            return _efPortfolioDal.GetById(id);
        }

        public List<Portfolio> TGetList()
        {
            return _efPortfolioDal.GetAll();
        }

        public void TUpdate(Portfolio t)
        {
            _efPortfolioDal.Update(t);
        }
    }
}
