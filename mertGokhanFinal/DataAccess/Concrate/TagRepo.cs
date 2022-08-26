using DataAccess.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate
{
    public class TagRepo : ITagRepo
    {
        public tag CreateTag(tag _tag)
        {
            using (var tagContextDb = new Context())
            {
                tagContextDb.tags.Add(_tag);
                tagContextDb.SaveChanges();
                return _tag;
            }
        }

        public void DeleteTag(int id)
        {
            using (var tagContextDb = new Context())
            {
                var deleteTag = GetTagsById(id);
                tagContextDb.tags.Remove(deleteTag);
                tagContextDb.SaveChanges();
            }
        }

        public List<tag> GetTags()
        {
            using (var tagContextDb = new Context())
            {
                return tagContextDb.tags.ToList();
            }
        }

        public tag GetTagsById(int id)
        {
            using (var tagContextDb = new Context())
            {
                return tagContextDb.tags.Find(id);
            }
        }

        public tag UpdateTag(tag _tag)
        {
            using (var tagContextDb = new Context())
            {
                tagContextDb.tags.Update(_tag);
                tagContextDb.SaveChanges();
                return _tag;
            }
        }
    }
}
