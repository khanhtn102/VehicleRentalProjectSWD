using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Model;
using VehicleRental.Repository;

namespace VehicleRental.Service
{
    public interface IOrderService : IBaseService<Order>
    {

    }

    public class OrderService : BaseService<Order>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork, IBaseRepository<Order> repository) : base(unitOfWork, repository)
        {
        }
    }
}
