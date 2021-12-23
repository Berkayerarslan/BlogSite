using BlogSite.Src.Entities;
using BlogSite.Src.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Src.Services
{
    public class TagService
    {
        private readonly TagRepository _tagRepo;
        public TagService(TagRepository tagRepository)
        {
            _tagRepo = tagRepository;
        }

        public void AddTag(Tag model)
        {
            _tagRepo.Add(model);
        }

        public List<Tag> GetAllTags()
        {
            return _tagRepo.List();
        }
    }
}
