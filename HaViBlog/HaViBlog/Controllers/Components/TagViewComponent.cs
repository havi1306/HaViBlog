using HaViBlog.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HaViBlog.Controllers.Components
{
    public class TagViewComponent : ViewComponent
    {
        private ITagService tagService;

        public TagViewComponent(ITagService _tagService)
        {
            tagService = _tagService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tags = tagService.GetAll();
            return await Task.FromResult((IViewComponentResult)View("Tags", tags));
        }
    }
}