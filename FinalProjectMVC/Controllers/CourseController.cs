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
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            var course = _courseSrvice.GetCourseList();
            var courseViewModel = course.Select(x=>new CourseViewModel(x));
            
            return View(courseViewModel);
        }
    }
}