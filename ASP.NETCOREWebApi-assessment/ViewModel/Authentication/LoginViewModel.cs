using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCOREWebAPI_assessment.ViewModel.Authentication
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User Name is mandatory")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is mandatory")]
        public string Password { get; set; }


    }
}
