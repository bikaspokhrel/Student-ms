using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student_ms.Database;

namespace Student_ms.Models
{
    public class Student_msContext : DbContext
    {
        public Student_msContext (DbContextOptions<Student_msContext> options)
            : base(options)
        {
        }

        public DbSet<Student_ms.Database.student> student { get; set; }
    }
}
