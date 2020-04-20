namespace ElevenLab.Models
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class EmplDbContext : DbContext
	{
		public EmplDbContext()
			: base("name=EmplDbContext")
		{
		}

		public DbSet<Position> Positions { get; set; }
		public DbSet<Worker> Workers { get; set; }

		public DbSet<History> Histories { get; set; }
	}
}