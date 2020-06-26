using KhongMinhKhiem_LAB456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using KhongMinhKhiem_LAB456.ViewModels;
using Microsoft.AspNet.Identity;

namespace KhongMinhKhiem_LAB456.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);

            var userId = User.Identity.GetUserId();

            var follows = _dbContext.Followings
                .Include(a => a.Followee)
                .Include(a => a.Follower)
                .Where(a => a.FollowerId == userId)
                .ToList();


            var attend = _dbContext.Attendances
                .Include(a => a.Attendee)
                .Include(a => a.Course)
                .Where(a => a.AttendeeId == userId)
                .ToList();

            var viewModel = new CoursesViewModel
            {
                UpcommingCourses = upcommingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}