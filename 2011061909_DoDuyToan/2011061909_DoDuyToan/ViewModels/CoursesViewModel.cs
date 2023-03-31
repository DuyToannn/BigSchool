using _2011061909_DoDuyToan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2011061909_DoDuyToan.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}