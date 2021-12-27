using BlogSite.Models;
using BlogSite.Src.Entities;
using BlogSite.Src.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PostService _postservice;
        private readonly CategoryService _categoryService;
        private readonly CommentService _commentService;
        private readonly TagService _tagService;


        public HomeController(ILogger<HomeController> logger, PostService postService, CategoryService categoryService,CommentService commentService,TagService tagService)
        {
            _logger = logger;
            _postservice = postService;
            _categoryService = categoryService;
            _commentService = commentService;
            _tagService = tagService;
        }

        public IActionResult Index(string title,string type, string id)
        {
            List<Post> posts = new List<Post>();

            List<Post> threePost = new List<Post>();
    
            if (string.IsNullOrEmpty(title))
            {
                posts = _postservice.GetAllPost();
                if (type == "tag")
                {
                    posts = _postservice.GetSelectTagPosts(id);
                }
                else if(type == "category")
                {
                    posts = _postservice.GetPostsByCategoryId(id);
                }
            }
            else
            {
                posts = _postservice.getPostByTitle(title);
            }

            threePost = _postservice.GetLastAddedThreePost();
            
            var categories = _categoryService.GetAllCategory();
            
            var tags = _tagService.GetAllTags();
            var model = new PostViewModel();
           
            
            model.Categories = categories;
            model.Tags = tags;  
            model.Posts = posts;
            
            
            
            return View(model);
        }
        public IActionResult PostDetail(string id)
        {
            
            var post = _postservice.GetPostById(id);
           
            var categories = _categoryService.GetAllCategory();
            var tags = _tagService.GetAllTags();
            var model = new PostViewModel();


            model.Categories = categories;
            model.Tags = tags;
            
            model.Post = post;
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
    }
}
