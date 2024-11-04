﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DD\\SQLEXPRESS01;database=CoreAppDb;integrated security=true;TrustServerCertificate=True;");
		}
		public DbSet<About> Abouts { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Portfolio> Portfolios { get; set; }
		public DbSet<Service> Skills { get; set; }
		public DbSet<SocailMedia> SocailMedias { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
	}
}
