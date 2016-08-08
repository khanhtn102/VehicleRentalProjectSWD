using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Model;
using VehicleRental.Repository;

namespace VehicleRental.Service
{
    public interface IVehicleImageService : IBaseService<VehicleImage>
    {

    }

    public class VehicleImageService : BaseService<VehicleImage>, IVehicleImageService
    {
        public VehicleImageService(IUnitOfWork unitOfWork, IBaseRepository<VehicleImage> repository) : base(unitOfWork, repository)
        {
        }
    }
}
