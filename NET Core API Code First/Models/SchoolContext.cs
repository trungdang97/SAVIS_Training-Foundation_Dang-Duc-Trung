using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCoreAPI_CodeFirst.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
    }

}
