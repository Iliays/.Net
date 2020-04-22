using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace Laba12.Models
{
	public class MyDbContext : DbContext
	{
		public MyDbContext() : 
			base("name=MyDbContext")
		{ }

		public DbSet<Message> Messages { get; set; }
		public DbSet<User> Users { get; set; }

	}
}