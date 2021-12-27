using BlogSite.Src.Entities;
using BlogSite.Src.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private readonly CategoryService _categoryService;

        public CategoriesViewComponent(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _categoryService.GetAllCategory();

            return View(await Task.FromResult(model));
        }

      
    }
}
