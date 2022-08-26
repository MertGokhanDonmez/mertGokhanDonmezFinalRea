using BusinessLayer.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrate;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class TagMan : ITagService
    {
        private ITagRepo _tagRepo;
        public TagMan()
        {
            _tagRepo = new TagRepo();
        }
        public tag CreateTag(tag _tag)
        {
            return _tagRepo.CreateTag(_tag);
        }

        public void DeleteTag(int id)
        {
            _tagRepo.DeleteTag(id);
        }

        public List<tag> GetTags()
        {
            return _tagRepo.GetTags();
        }

        public tag GetTagsById(int id)
        {
            if (id > 0)
            {
                return _tagRepo.GetTagsById(id);
            }
            throw new Exception("ID 1 in altinda olamaz!!!");
        }

        public tag UpdateTag(tag _tag)
        {
            return _tagRepo.UpdateTag(_tag);
        }
    }
}
