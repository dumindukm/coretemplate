using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySample_DataService.Configurations;
using MySample_Domain;
using MySample_Domain.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Configuration;

namespace MySample_DataService.Common
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DbSet<EntityA> EntityAs { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            //Database.SetInitializer(new DatabaseInitializer());

            //options.UseSqlServer(ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["SampleDatabase"].ConnectionString);
        }

        public new DbSet<T> Set<T>() where T : class, IEntity
        {
            return base.Set<T>();
        }
         
        public void Save()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EntityAConfig());
        }

        //DbSet<T> IDatabaseContext.Set<T>()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
