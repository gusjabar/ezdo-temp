using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Repository;

namespace ezDoctorOffice_2.Migrations
{
    [DbContext(typeof(DocOffContext))]
    [Migration("20170702034318_ini")]
    partial class ini
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ezDoctorOffice_2.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
        }
    }
}
