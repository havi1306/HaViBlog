﻿using HaViBlog.Areas.Admin.Models;
using HaViBlog.Service.Services;
using HaViBlog.Utilities.Constaint;
using HaViBlog.Utilities.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HaViBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private ILoginService loginService;

        public HomeController(ILoginService _loginService)
        {
            loginService = _loginService;
        }

        public IActionResult Index()
        {
            var userName = HttpContext.Session.GetString(UserConstants.USER_NAME);
            if (string.IsNullOrEmpty(userName))
                return RedirectToAction(nameof(Login));
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                string passWordMD5 = EncryptUtil.EncryptMD5(model.UserName + model.Password);
                var user = loginService.checkLogin(model.UserName, passWordMD5);
                if (user != null)
                {
                    HttpContext.Session.SetString(UserConstants.USER_ID, user.Id.ToString());
                    HttpContext.Session.SetString(UserConstants.USER_NAME, user.UserName);
                    HttpContext.Session.SetString(UserConstants.USER_PASS, user.Password);
                    HttpContext.Session.SetString(UserConstants.USER_AVATAR, user.Avatar);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.error = passWordMD5;
                    //ViewBag.error = "username or pass không đúng or do m đã bị lock";
                }
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Login));
        }

        public IActionResult NotificationAuthorize()
        {
            return View();
        }
    }
}