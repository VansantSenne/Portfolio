using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Entities
{
    [Table("category", Schema = "portfolio")]
    public class Category
    {
        [Key]
        public int ObjectId { get; set; }
        public string Name { get; set; }
    }
}
