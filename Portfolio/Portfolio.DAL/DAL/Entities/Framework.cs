using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("framework", Schema = "portfolio")]

    public class Framework
    {
        [Key]
        public int FrameworkId { get; set; }
        public string Name { get; set; }
    }
}
