using FinalProject.BusinessLogic.Services;
using FinalProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseSrvice
            = new CourseService();
        private CourseViewModel courseViewModel;
        // GET: Course
        public ActionResult List()
        {
            var course = _courseSrvice.GetCourseList();            
            return View(course);
        }
    }
}