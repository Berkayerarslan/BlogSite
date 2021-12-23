using BlogSite.Src.EFCore;
using BlogSite.Src.Entities;
using BlogSite.Src.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Src.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private readonly ApplicationDbContext _db;
        

        public TagRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Add(Tag model)
        {
            _db.Tags.Add(model);
            _db.SaveChanges();    
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public Tag Find(string Id)
        {
            return _db.Tags.Find(Id);
            
        }

        public List<Tag> List()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public bool SaveResult()
        {
            throw new NotImplementedException();
        }

        public void Update(Tag model)
        {
            throw new NotImplementedException();
        }
    }
}
