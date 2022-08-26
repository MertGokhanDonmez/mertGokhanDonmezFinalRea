using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITagService
    {
        List<tag> GetTags();
        tag GetTagsById(int id);
        tag CreateTag(tag _tag);
        tag UpdateTag(tag _tag);
        void DeleteTag(int id);
    }
}
