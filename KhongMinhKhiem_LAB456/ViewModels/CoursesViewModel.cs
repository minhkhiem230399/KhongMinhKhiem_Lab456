using KhongMinhKhiem_LAB456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KhongMinhKhiem_LAB456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }

        public IEnumerable<ApplicationUser> Follows { get; set; }

        public List<Following> FollowingUser { get; set; }


        public List<Attendance> AttendanceCourse { get; set; }


        public string UserID { get; set; }

        public bool ShowAction { get; set; }
    }
}