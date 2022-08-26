using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class product
    {
        [Key]
        public int productID { get; set; }
        [StringLength(50)]
        public string productName { get; set; }
        public int stock { get; set; }
        public virtual category categories { get; set; }

        public IEnumerable<tag_product> tag_products { get; set; }


    }
}
