using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Model;

namespace VehicleRental.Repository
{
    public interface IVehicleImageRepository : IBaseRepository<VehicleImage>
    {

    }

    public class VehicleImageRepository : BaseRepository<VehicleImage>, IVehicleImageRepository
    {
        public VehicleImageRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
