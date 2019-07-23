using Autofac;
using Microsoft.EntityFrameworkCore;
using MySample_CoreInterfaces;
using MySample_CoreServices;
using MySample_DataService;
using MySample_DataService.Common;
using MySample_Utility;
using MySample_Utility.interfaces;
using MySampleDataInterfaces;
using MySampleDataInterfaces.Common;
using System;


namespace MySample_Dependencies
{
    public class AutofacPorviderIOC : Module
    {
        //public static IContainer GetContainer(ContainerBuilder builder)
        //{
        //    builder.RegisterType<MyService>().As<IMyService>();
        //    return builder.Build();
        //}
        protected override void Load(ContainerBuilder builder)
        {
            //builder.Register(c =>
            //{

            //    var config = c.Resolve<Microsoft.Extensions.Configuration.IConfiguration>();

            //    var opt = new Microsoft.EntityFrameworkCore.DbContextOptionsBuilder<DatabaseContext>();
            //    opt.UseSqlServer(config.GetSection("ConnectionStrings:SampleDatabase").Value);
            //    //Configuration.GetConnectionString("SampleDatabase")

            //    return new DatabaseContext(opt.Options);
            //}).AsSelf().InstancePerLifetimeScope();

            builder.RegisterType<CustomLogger>().As<ICustomLogger>();
            builder.RegisterType<EntityAService>().As<IEntityAService>();
            builder.RegisterType<EntityADataService>().As<IEntityADataService>();
            builder.RegisterType<DatabaseContext>().As<IDatabaseContext>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

           
        }
    }
}
