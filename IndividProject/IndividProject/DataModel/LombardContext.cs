namespace IndividProject.DataModel
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class LombardContext : DbContext
	{
		public LombardContext()
			: base("name=LombardContext")
		{
		}

		public DbSet<Client> Clients { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Journal> Journals { get; set; }
		public DbSet<User> Users { get; set; }
	}
}