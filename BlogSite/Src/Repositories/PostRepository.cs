using BlogSite.Src.EFCore;
using BlogSite.Src.Entities;
using BlogSite.Src.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Src.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private readonly ApplicationDbContext _db;

        public PostRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Add(Post model)
        {
            _db.Posts.Add(model);
            _db.SaveChanges();
        }

        public void Delete(string Id)
        {
            _db.Remove(_db.Posts.Find(Id));
            _db.SaveChanges();
        }

        public Post Find(string Id)
        {
            return _db.Posts.Find(Id);
        }

        public List<Post> List()
        {
            return _db.Posts.ToList();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public bool SaveResult()
        {
            throw new NotImplementedException();
        }

        public void Update(Post model)
        {
            _db.Posts.Update(model);
            _db.SaveChanges();
        }
    }
}
