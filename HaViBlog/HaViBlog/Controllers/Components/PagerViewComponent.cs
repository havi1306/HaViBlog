﻿using HaViBlog.Utilities.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HaViBlog.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}