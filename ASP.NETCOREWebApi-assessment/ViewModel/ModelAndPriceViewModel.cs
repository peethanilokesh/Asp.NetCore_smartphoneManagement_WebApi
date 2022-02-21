using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCOREWebAPI_assessment.ViewModel
{
    public class ModelAndPriceViewModel
    {

        [Required(ErrorMessage = "Model is mandatory")]
        [MinLength(20, ErrorMessage = "Model must be minimum of 20 characters.")]
        public string Model { get; set; }
       
        [Required(ErrorMessage = "Price is mandatory")]
        [MinLength(6, ErrorMessage = "Price must be minimum of 6 characters.")]
        public string Price { get; set; }
    }
}
