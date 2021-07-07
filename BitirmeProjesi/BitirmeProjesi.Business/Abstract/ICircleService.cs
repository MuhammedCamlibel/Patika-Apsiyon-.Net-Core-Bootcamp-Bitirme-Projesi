using BitirmeProjesi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Business.Abstract
{
    public interface ICircleService
    {
         

        void Create(Circle entity);
        void Update(Circle entity);
        void Delete(Circle entity);
        List<Circle> GetAll();
        Circle GetById(int id);
        Circle GetByIdWithUser(int id);
        List<Circle> GetByUserIdWithUserAndInvoice(string id);
    }
}
