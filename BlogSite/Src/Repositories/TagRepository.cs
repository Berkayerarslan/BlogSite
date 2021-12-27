using BlogSite.Src.EFCore;
using BlogSite.Src.Entities;
using BlogSite.Src.SeedWork;
using Microsoft.EntityFrameworkCore;
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

        internal object Include()
        {
            throw new NotImplementedException();
        }

        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public Tag Find(string Id)
        {
            return _db.Tags.Include(x=> x.Posts).FirstOrDefault(x=> x.Id == Id);
            
        }

        public List<Tag> List()
        {
            return _db.Tags.Include(x => x.Posts).ToList();
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
