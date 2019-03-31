using HaViBlog.Areas.Admin.Data;
using HaViBlog.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace HaViBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [ServiceFilter(typeof(AuthorizeBusiness))]
    public class UserController : Controller
    {
        private IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

        public IActionResult Index()
        {
            var users = userService.GetAll();
            return View(users);
        }
    }
}