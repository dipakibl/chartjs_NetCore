using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chart_ike_dashboard.Models
{
    public class User_Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Sales { get; set; }
        public string Income { get; set; }
        public DateTime Date { get; set; }
    }
}
