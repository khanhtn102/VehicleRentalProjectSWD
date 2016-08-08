using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Model;

namespace VehicleRental.Repository
{
    public interface IVehicleRepository : IBaseRepository<Vehicle>
    {

    }

    public class VehicleRepository : BaseRepository<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
