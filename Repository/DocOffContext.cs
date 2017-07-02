using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Entities;

namespace Repository
{
    public class DocOffContext : IdentityDbContext<DocOffUser>
	{
		IConfigurationRoot _config;
		public DocOffContext(IConfigurationRoot config, DbContextOptions options) : base(options)
		{
			_config = config;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			base.OnConfiguring(optionsBuilder);
                       
			optionsBuilder.UseSqlServer(_config["ConnectionStrings:DocOffContext"],b => b.MigrationsAssembly("ezDoctorOffice_2"));
		}

		public DbSet<Customer> Customers { get; set; }
        public DbSet<DocOffUser> UserIdentity { get; set; }
	}
}
