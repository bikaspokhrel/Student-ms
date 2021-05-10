using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_ms.Database;
using Student_ms.Models;

namespace Student_ms.Pages.students
{
    public class IndexModel : PageModel
    {
        private readonly Student_ms.Models.Student_msContext _context;

        public IndexModel(Student_ms.Models.Student_msContext context)
        {
            _context = context;
        }

        public IList<student> student { get;set; }

        public async Task OnGetAsync()
        {
            student = await _context.student.ToListAsync();
        }
    }
}
