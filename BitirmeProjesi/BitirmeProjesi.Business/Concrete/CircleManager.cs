using BitirmeProjesi.Business.Abstract;
using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Data.Concrete;
using BitirmeProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Business.Concrete
{
    public class CircleManager : ICircleService
    {
        private ICircleRepository _circleRepository;

        public CircleManager(ICircleRepository circleRepository)
        {
            _circleRepository = circleRepository;
        }

        public void Create(Circle entity)
        {
            _circleRepository.Create(entity);
        }

        public void Delete(Circle entity)
        {
            _circleRepository.Delete(entity);
        }

        public List<Circle> GetAll()
        {
            return _circleRepository.GetAll();
        }

        public Circle GetById(int id)
        {
            return _circleRepository.GetById(id);
        }

        public Circle GetByIdWithUser(int id)
        {
            return _circleRepository.GetByIdWithUser(id);
        }

        public List<Circle> GetByUserIdWithUserAndInvoice(string id)
        {
            return _circleRepository.GetByUserIdWithUserAndInvoice(id);
        }

        public void Update(Circle entity)
        {
            _circleRepository.Update(entity);
        }
    }
}
