using BitirmeProjesi.Data.Abstract;
using BitirmeProjesi.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Data.Concrete
{
    public class CircleRepository : GenericRepository<Circle>,ICircleRepository
    {
        public CircleRepository(ProjeDbContext context):base(context)
        {

        }

        public Circle GetByIdWithUser(int id)
        {
            /*using(var context = new ProjeDbContext())
            {

            }*/
            // önemli detay !!! base sınıftaki context objesini protected yaparak burada kullanabildik

            return _context.Circle.Where(c => c.Id == id).Include(c => c.User).FirstOrDefault();
        }

        public List<Circle> GetByUserIdWithUserAndInvoice(string id)
        {
            return _context.Circle.Where(c => c.User.Id == id).Include(c => c.Invoices).Include(c => c.User).ToList();
        }
    }
}
