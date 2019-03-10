using FinalProject.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalProject.Controllers
{
   
    public class UserController : ApiController
    {

        public readonly IUserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }
        [HttpGet]

        public IHttpActionResult GetAll()
        {
            var userList = _userService.GetAll();
            return Ok(userList);
        }
    }
}
