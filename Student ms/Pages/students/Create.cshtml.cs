using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student_ms.Database;
using Student_ms.Models;

namespace Student_ms.Pages.students
{
    public class CreateModel : PageModel
    {
        private readonly Student_ms.Models.Student_msContext _context;

        public CreateModel(Student_ms.Models.Student_msContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public student student { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.student.Add(student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}