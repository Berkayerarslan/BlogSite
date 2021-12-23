using BlogSite.Src.EFCore;
using BlogSite.Src.Entities;
using BlogSite.Src.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Src.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {

        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Add(Category model)
        {
            _db.Categories.Add(model);
            _db.SaveChanges();
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public Category Find(string Id)
        {
           return _db.Categories.Find(Id);

        }

        public List<Category> List()
        {
            return _db.Categories.ToList();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public bool SaveResult()
        {
            throw new NotImplementedException();
        }

        public void Update(Category model)
        {
            throw new NotImplementedException();
        }
    }
}
