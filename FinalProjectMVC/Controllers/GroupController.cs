using FinalProject.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProjectMVC.Controllers
{
    public class GroupController : Controller
    {
        private readonly IStudentService groupService 
            = new GroupService();
        

        public ActionResult List()
        {
            var groupList = groupService.GetGroupList();

            return View(groupList);
        }
    }
}