using HaViBlog.Models;
using HaViBlog.Service.Services;
using HaViBlog.Service.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HaViBlog.Controllers
{
    public class HomeController : Controller
    {
        private IPostService postService;
        private ICommentService commentService;

        public HomeController(IPostService _postService)
        {
            postService = _postService;
        }

        public IActionResult Index(int page = 1)
        {
            var list = postService.GetAllPaging(string.Empty, page, 10);
            return View(list);
        }

        [Route("tim-kiem.html", Name = "Search")]
        public IActionResult Search(string keyword, int page = 1)
        {
            var list = postService.GetAllPaging(keyword, page, 10);
            return View(list);
        }

        [Route("{Alias}-post.{id}.html")]
        public IActionResult Details(int id)
        {
            var model = postService.GetDetail(id);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Home/AddComment")]
        [HttpPost]
        public JsonResult AddComment([FromBody]CommentViewModel commentViewModel)
        {
            bool stt = false;
            string msg = string.Empty;
            var comment = commentService.Add(commentViewModel);
            if (comment == null)
            {
                msg = "<div class='alert alert-success'>Comment thất bại</div>";
            }
            else
            {
                stt = true;
                msg = "<div class='alert alert-success'>Comment thành công và đang chờ duyệt</div>";
            }
            commentService.Save();
            return Json(new
            {
                status = stt,
                message = msg
            });
        }
    }
}