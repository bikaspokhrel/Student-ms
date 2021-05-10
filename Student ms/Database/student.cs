using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Student_ms.Database
{
    public class student
    {
        [Key]
        public int StudentID { get; set; }

        public string Student_Name { get; set; }

        public DateTime DoB { get; set; }
    }
}
