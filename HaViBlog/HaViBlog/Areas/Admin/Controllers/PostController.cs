using HaViBlog.Areas.Admin.Data;
using HaViBlog.Service.Services;
using HaViBlog.Service.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HaViBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    [ServiceFilter(typeof(AuthorizeBusiness))]
    public class PostController : Controller
    {
        private IPostService postService;

        public PostController(IPostService _postService)
        {
            postService = _postService;
        }

        public IActionResult Index()
        {
            var posts = postService.GetAll();
            return View(posts);
        }

        // GET: Posts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,Description,Content,Thumbnail,CreateDate,UpdateDate,Status,Alias,UserId,ViewCount")] PostViewModel postVm)
        {
            if (ModelState.IsValid)
            {
                postService.Add(postVm);
                postService.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(postVm);
        }
    }
}