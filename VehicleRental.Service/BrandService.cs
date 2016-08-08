using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Model;
using VehicleRental.Repository;

namespace VehicleRental.Service
{
    public interface IBrandService : IBaseService<Brand>
    {

    }

    public class BrandService : BaseService<Brand>, IBrandService
    {
        public BrandService(IUnitOfWork unitOfWork, IBaseRepository<Brand> repository) : base(unitOfWork, repository)
        {
        }
    }
}
