using Apsiyon.Application.Interfaces;
using Apsiyon.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apsiyon.WebUI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService = null;

        public UserController(IUserService userService) 
        {
            _userService = userService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.Users = _userService.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Add(UserViewModel model)
        {
            _userService.Add(model);
            return View();
        }
    }
}
