using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace DataAccessLayer.EntityFreamwork
{
	public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
	{
		public List<UserMessage> GetUserMessagesWithUser()
		{
			using (var context = new Context())
			{
				return context.UserMessages.Include(x => x.User).ToList();
			}
		}
	}
}
