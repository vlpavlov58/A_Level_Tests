using FinalProject.BusinessLogic.Services;
using FinalProject.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserService userService =
            new UserService();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            var users = userService.GetUserList();
            var userViewModel = users.Select(x => new UserViewModel(x));

            return View(userViewModel);
        }

      
    
}