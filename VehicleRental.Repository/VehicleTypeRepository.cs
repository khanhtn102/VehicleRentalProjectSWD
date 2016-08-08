using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Model;

namespace VehicleRental.Repository
{
    public interface IVehicleTypeRepository : IBaseRepository<VehicleType>
    {

    }

    public class VehicleTypeRepository : BaseRepository<VehicleType>, IVehicleTypeRepository
    {
        public VehicleTypeRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
