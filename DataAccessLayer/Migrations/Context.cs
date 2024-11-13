using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class Context: IdentityDbContext<WriterUser, WriterRole, int>
    {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DD\\SQLEXPRESS01;database=CoreAppDb;integrated security=true;TrustServerCertificate=True;");
		}
		
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<About> Abouts { get; set; }
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Portfolio> Portfolios { get; set; }
		public DbSet<Service> Services { get; set; }
		public DbSet<Skill> Skills { get; set; }
		
		public DbSet<SocailMedia> SocailMedias { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
		public DbSet<Users> Users { get; set; }
		public DbSet<UserMessage> UserMessages { get; set; }
		public DbSet<ToDoList> toDoLists { get; set; }
		public DbSet<Announcement> Announcements { get; set; }
      


    }
}
