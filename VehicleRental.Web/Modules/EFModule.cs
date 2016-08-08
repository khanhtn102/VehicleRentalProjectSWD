using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using VehicleRental.Model;
using System.Data.Entity;
using VehicleRental.Repository;

namespace VehicleRental.Web.Modules
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType(typeof(VehicleRentalEntities)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
        }
    }
}