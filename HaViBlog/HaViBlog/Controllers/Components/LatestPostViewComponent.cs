using HaViBlog.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HaViBlog.Controllers.Components
{
    public class LatestPostViewComponent : ViewComponent
    {
        private IPostService postService;

        public LatestPostViewComponent(IPostService _postService)
        {
            postService = _postService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoryGroup = postService.GetLatest();
            return await Task.FromResult((IViewComponentResult)View("LatestPost", categoryGroup));
        }
    }
}