using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class ToyModel
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? CountryName { get; set; }

        [Required]
        public string TypeName { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Enter valid price")]
        public int? Price { get; set; }


        [Required]
        [Url]
        public string? ImageName { get; set; }
    }
}
