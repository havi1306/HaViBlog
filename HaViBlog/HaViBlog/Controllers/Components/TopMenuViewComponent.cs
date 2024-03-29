﻿using HaViBlog.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HaViBlog.Controllers.Components
{
    public class TopMenuViewComponent : ViewComponent
    {
        private ICategoryService categoryService;

        public TopMenuViewComponent(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var category = categoryService.GetAll();
            return await Task.FromResult((IViewComponentResult)View("Categories", category));
        }
    }
}