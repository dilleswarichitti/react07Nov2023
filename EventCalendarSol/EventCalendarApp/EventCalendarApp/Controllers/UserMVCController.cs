using EventCalendarApp.Interface;
using EventCalendarApp.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventCalendarApp.Controllers
{
    public class UserMVCController : Controller
    {
        private readonly IUserService _userService;

        public UserMVCController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserDTO userDTO)
        {
            var user = _userService.Login(userDTO);
            if (user != null)
            {
                TempData.Add("email", userDTO.Email);
                return RedirectToAction("Index", "Home");
            }
            ViewData["Message"] = "Invalid email or password";
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserViewModel viewModel)
        {
            try
            {
                var user = _userService.Register(viewModel);
                if (user != null)
                {
                    return RedirectToAction("Login");
                }
            }
            catch (DbUpdateException exp)
            {
                ViewBag.Message = "User name already exits";
            }
            catch (Exception)
            {
                ViewBag.Message = "Invalid data. Coudld not register";
                throw;
            }
            //ViewData["Message"] = "Invalid data. Coudld not register";

            return View();
        }
    }
}
