using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class tag_product
    {
        [Key]
        public int id { get; set; }
        // tag table
        public tag tag { get; set; }
        public int tagID { get; set; }
        // product table
        public product product { get; set; }
        public int productID { get; set; }
    }
}
