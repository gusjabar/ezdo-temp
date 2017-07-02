using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Entities;

namespace Repository
{
	public class DocOffContext : DbContext
	{
		IConfigurationRoot _config;
		public DocOffContext(IConfigurationRoot config, DbContextOptions options) : base(options)
		{
			_config = config;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer(_config["ConnectionStrings:DocOffContext"]);
		}

		public DbSet<User> Users { get; set; }
	}
}
