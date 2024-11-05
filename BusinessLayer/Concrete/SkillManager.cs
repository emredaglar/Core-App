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
    public class SkillManager:ISkillService
    {
        ISkillDal _Skilldal;

        public SkillManager(ISkillDal skillDal)
        {
            _Skilldal = skillDal;
        }

        public void TAdd(Skill t)
        {
            _Skilldal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _Skilldal.Delete(t);
        }

        public Skill TGetByID(int id)
        {
            return _Skilldal.GetById(id);
        }

        public List<Skill> TGetList()
        {
            return _Skilldal.GetAll();
        }

        public void TUpdate(Skill t)
        {
            _Skilldal.Update(t);
        }
    }
}
