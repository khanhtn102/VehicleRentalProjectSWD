using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Model;
using VehicleRental.Repository;

namespace VehicleRental.Service
{
    public interface IUserService : IBaseService<User>
    {

    }

    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IBaseRepository<User> repository) : base(unitOfWork, repository)
        {
        }
    }
}
