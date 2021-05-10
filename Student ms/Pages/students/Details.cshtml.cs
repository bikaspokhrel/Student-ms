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
    public class DetailsModel : PageModel
    {
        private readonly Student_ms.Models.Student_msContext _context;

        public DetailsModel(Student_ms.Models.Student_msContext context)
        {
            _context = context;
        }

        public student student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            student = await _context.student.FirstOrDefaultAsync(m => m.StudentID == id);

            if (student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
