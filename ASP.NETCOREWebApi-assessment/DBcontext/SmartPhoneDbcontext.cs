using ASP.NETCOREWebAPI_assessment.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCOREWebAPI_assessment.DBcontext
{
    public class SmartPhoneDbcontext: IdentityDbContext<IdentityUser>
    {
        public SmartPhoneDbcontext(DbContextOptions<SmartPhoneDbcontext> options) : base(options)
        {

        }
        public DbSet<SmartPhone> smartPhones { get; set; }
    }
}
