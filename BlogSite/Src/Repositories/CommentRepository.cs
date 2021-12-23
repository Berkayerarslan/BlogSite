using BlogSite.Src.EFCore;
using BlogSite.Src.Entities;
using BlogSite.Src.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Src.Repositories
{
    public class CommentRepository : IRepository<Comment>
    {
        private readonly ApplicationDbContext _db;

        public CommentRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Add(Comment model)
        {
            _db.Comments.Add(model);
            _db.SaveChanges();
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public Comment Find(string Id)
        {
            return _db.Comments.Find(Id);
        }

        public List<Comment> List()
        {
            return _db.Comments.ToList();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public bool SaveResult()
        {
            throw new NotImplementedException();
        }

        public void Update(Comment model)
        {
            _db.Comments.Update(model);
            _db.SaveChanges();
        }
    }
}
