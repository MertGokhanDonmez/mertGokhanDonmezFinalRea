using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class tag
    {
        [Key]
        public int tagID { get; set; }
        [StringLength(50)]
        public string tagName { get; set; }
        public IEnumerable<tag_product> tag_products { get; set; }
    }
}
