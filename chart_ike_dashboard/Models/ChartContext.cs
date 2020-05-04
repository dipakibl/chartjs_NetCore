using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chart_ike_dashboard.Models
{
    public class ChartContext:DbContext
    {
        public ChartContext(DbContextOptions<ChartContext> options):base(options)
        {
        }
        public ChartContext()
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Account> User_Accounts { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }
    }
}
