using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chart_ike_dashboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace chart_ike_dashboard.Controllers
{
    public class AccountController : Controller
    {
        private readonly ChartContext _Context;
        public AccountController(ChartContext context)
        {
            _Context = context;
        }
       public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var data = _Context.Users.Where(a => a.Email == user.Email && a.Password == user.Password).FirstOrDefault();
            if (data != null)
            {
                TempData["Message"] = data.Name;
                DateTime date =  DateTime.Now;
                var log = _Context.UserLogs.Where(a => a.Date == date.Date && a.UserId == data.Id).FirstOrDefault();
                if (log == null)
                {
                    UserLog userLog = new UserLog();
                    userLog.UserId = data.Id;
                    userLog.UserName = data.Name;
                    userLog.Date = date.Date;
                    userLog.Count = 1;
                    _Context.UserLogs.Add(userLog);
                    _Context.SaveChanges();
                }
                else
                {
                    log.Count = (log.Count + 1);
                    _Context.Update(log);
                    _Context.SaveChanges();
                }
                return RedirectToAction("Index", "Dashboard");
            }
            ViewBag.Invalid = "Invalid Email & Password..!";
            return View();
        }

        public ActionResult Logout()
        {
            TempData["Message"] = null;
            return RedirectToAction("Login", "Account");
        }
    }
}