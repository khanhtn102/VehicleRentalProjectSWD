using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRental.Repository;

namespace VehicleRental.Service
{
    public abstract class BaseService<T> : IBaseService<T> where T : class
    {
        IUnitOfWork unitOfWork;
        IBaseRepository<T> repository;

        public BaseService(IUnitOfWork unitOfWork, IBaseRepository<T> repository)
        {
            this.unitOfWork = unitOfWork;
            this.repository = repository;
        }

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            repository.Insert(entity);
            unitOfWork.Commit();
        }

        public void Delete(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            repository.Delete(entity);
            unitOfWork.Commit();
        }

        public IEnumerable<T> GetAll()
        {
            return repository.SelectAll();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            repository.Update(entity);
            unitOfWork.Commit();
        }
    }
}
