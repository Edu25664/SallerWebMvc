using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SallerWebMvc.Controllers.entities;

namespace SallerWebMvc.Data
{
    public class SallerWebMvcContext : DbContext
    {
        public SallerWebMvcContext (DbContextOptions<SallerWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SallerWebMvc.Controllers.entities.Departments> Departments { get; set; }
    }
}
