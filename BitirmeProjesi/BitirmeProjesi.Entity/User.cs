using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Entity
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TCNO { get; set; }
        public string CarPlate { get; set; }
        public string Phone { get; set; }
        public List<Circle> Circles { get; set; }
        public List<Message> Messages { get; set; }
        public List<PaidBills> PaidBills { get; set; }


    }
}
