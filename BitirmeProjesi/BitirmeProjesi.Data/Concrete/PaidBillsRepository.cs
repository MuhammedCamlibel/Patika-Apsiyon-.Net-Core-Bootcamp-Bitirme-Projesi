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
    public class PaidBillsRepository : GenericRepository<PaidBills>,IPaidBillsRepository 
    {
        public PaidBillsRepository(ProjeDbContext context):base(context)
        {

        }

        public List<PaidBills> GetAllPaidBillsWithUser()
        {
            return _context.PaidBills.Include(p => p.Circle).ThenInclude(c => c.User).ToList();
        }
    }
}
