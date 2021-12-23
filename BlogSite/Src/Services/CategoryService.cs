using BlogSite.Src.Entities;
using BlogSite.Src.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Src.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepo;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepo = categoryRepository;
        }

        public List<Category> GetAllCategory()
        {
            var categories = _categoryRepo.List();
            return categories;
        }

       

    }
}
