using BlogSite.Src.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.ViewComponents
{
    public class RecentPostsViewComponent: ViewComponent
    {

        private readonly PostService _postService;

        public RecentPostsViewComponent(PostService postService)
        {
            _postService = postService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model =_postService.GetLastAddedThreePost();

            return View(await Task.FromResult(model));
        }

    }
}
