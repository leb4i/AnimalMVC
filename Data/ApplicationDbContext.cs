using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using animalsMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace animalsMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<animalsMVC.Models.Animal> Animal { get; set; } = default!;
    }
}
