using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chart_ike_dashboard.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
    }
}
