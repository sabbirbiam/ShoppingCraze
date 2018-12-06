using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCraze.Entities
{
    public class Course
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Course Name Required")]
        public string Name { get; set; }
        public double Credit { get; set; }
    }
}
