using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chart_ike_dashboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace chart_ike_dashboard.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ChartContext _Context;
        public DashboardController(ChartContext context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            var data = _Context.UserLogs.ToList();
            return View(data);
        }
        public JsonResult PerdayLogin()
        {
            var data = _Context.UserLogs.Where(a => a.Date == DateTime.Today).ToList();
            return Json(data);
        }

        public IActionResult Account()
        {
            var data = _Context.User_Accounts.Where(a => a.Date == DateTime.Today).ToList();
            return View(data);
        }
    }
}