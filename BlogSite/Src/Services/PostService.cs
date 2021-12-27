using BlogSite.Src.Entities;
using BlogSite.Src.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Src.Services
{
    public class PostService
    {
        private readonly PostRepository _postRepo;
        private readonly TagRepository _tagRepo;
        private readonly CategoryRepository _categoryRepo;
       
        public PostService(PostRepository postRepository, TagRepository tagRepository, CategoryRepository categoryRepository)
        {
            _postRepo = postRepository;
            _categoryRepo = categoryRepository;
            _tagRepo = tagRepository;
        }

        public void AddPost(Post model)
        {
            _postRepo.Add(model);
        }

        public List<Post> GetAllPost()
        {
           return _postRepo.List();
        }

        public List<Post> getPostByTitle(string title)
        {
            return _postRepo.List().Where(x => x.Title == title).ToList();
        }
        public Post GetPostById(string Id)
        {
            return _postRepo.Find(Id);
        }

        public int GetCommentCount(string Id)
        {
            return GetPostById(Id).Comments.Count();
        }

        public List<Post> GetLastAddedThreePost()
        {
            var LastPosts = GetAllPost().OrderByDescending(x => x.CreateTime).Take(3).ToList();
            return LastPosts;
        }
        public List<Tag> GetPostTags(string Id)
        {
            var tags = _postRepo.Find(Id).Tags;
            return tags;
        }
        public List<Comment> GetPostComments(string Id)
        {
            var comments = _postRepo.Find(Id).Comments.ToList();
            return comments;
        }
        
        public List<Post> GetSelectTagPosts(string tagId)
        {
            var tags = _tagRepo.List();
            var selectTag = tags.Find(x => x.Id == tagId);

            List<Post> selectedPosts = new List<Post>();

            selectedPosts = selectTag.Posts;

            //foreach (var tag in tags)
            //{
            //    if (tag.Id == tagId)
            //    {               
            //        selectedPosts.AddRange(tag.Posts);
            //    }
            //}

            return selectedPosts;
            
        }

        public List<Post> GetPostsByCategoryId(string categoryId)
        {
            var selectPosts = GetAllPost().Where(x => x.CategoryId == categoryId).ToList();
            return selectPosts;
        }






    }
}
