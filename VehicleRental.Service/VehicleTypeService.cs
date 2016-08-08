using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Model;
using VehicleRental.Repository;

namespace VehicleRental.Service
{
    public interface IVehicleTypeService : IBaseService<VehicleType>
    {

    }

    public class VehicleTypeService : BaseService<VehicleType>, IVehicleTypeService
    {
        public VehicleTypeService(IUnitOfWork unitOfWork, IBaseRepository<VehicleType> repository) : base(unitOfWork, repository)
        {
        }
    }
}
