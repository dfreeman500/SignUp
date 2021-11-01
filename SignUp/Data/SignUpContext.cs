using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SignUp.Models;

namespace SignUp.Data
{
    public class SignUpContext : DbContext
    {
        public SignUpContext (DbContextOptions<SignUpContext> options)
            : base(options)
        {
        }

        public DbSet<SignUp.Models.Event> Event { get; set; }

        public DbSet<SignUp.Models.Person> Person { get; set; }
    }
}
