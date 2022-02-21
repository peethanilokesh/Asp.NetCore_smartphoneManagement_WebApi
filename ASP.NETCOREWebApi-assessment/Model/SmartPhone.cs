using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCOREWebAPI_assessment.Model
{
    public class SmartPhone
    {
        [Required(ErrorMessage = "Id is mandatory")]
        public int id { get; set; }

        [Required(ErrorMessage = "Model is mandatory")]
        [MinLength(20, ErrorMessage = "Model must be minimum of 20 characters.")]
        public string Model { get; set; }
        [MinLength(20, ErrorMessage = "Name must be minimum of 20 characters.")]
        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Features is mandatory")]
        [MinLength(50, ErrorMessage = "Feature must be minimum of 50 characters.")]
        public string Feature { get; set; }
        [Required(ErrorMessage = "Price is mandatory")]
        [MinLength(6, ErrorMessage = "Price must be minimum of 6 characters.")]
        public string Price { get; set; }

    }
}
