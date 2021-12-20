using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Class_Project.Data;
using Class_Project.Models;

namespace Class_Project.Pages
{
    public class LocationModel : PageModel
    {
        private readonly Class_Project.Data.Class_ProjectContext _context;

        public LocationModel(Class_Project.Data.Class_ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Class_ProjectModel Class_ProjectModel { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Class_ProjectModel.Add(Class_ProjectModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Confirmation");
        }
    }
}
