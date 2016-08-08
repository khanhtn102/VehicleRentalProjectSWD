using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Model;
using VehicleRental.Repository;

namespace VehicleRental.Service
{
    public interface IVehicleService : IBaseService<Vehicle>
    {

    }

    public class VehicleService : BaseService<Vehicle>, IVehicleService
    {
        public VehicleService(IUnitOfWork unitOfWork, IBaseRepository<Vehicle> repository) : base(unitOfWork, repository)
        {
        }
    }
}
