using BlogSite.Src.Entities;
using BlogSite.Src.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Src.Services
{
    public class CommentService
    {
        private readonly CommentRepository _commentRepo;
        private readonly PostRepository _postRepo;

        public CommentService(CommentRepository commentRepository, PostRepository postRepository)
        {
            _commentRepo = commentRepository;
            _postRepo = postRepository;
        }

        public void AddComment(Comment model)
        {
            _commentRepo.Add(model);
        }

        public List<Comment> GetAllComments()
        {
            return _commentRepo.List();
        }

        public List<Comment> GettCommentsByPost(string postId)
        {
            var post = _postRepo.Find(postId);
            return post.Comments.ToList();

        }
    }
}
