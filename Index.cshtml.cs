using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Class_Project.Data;
using Class_Project.Models;

namespace Class_Project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Class_Project.Data.Class_ProjectContext _context;

        public IndexModel(Class_Project.Data.Class_ProjectContext context)
        {
            _context = context;
        }

        public IList<Class_ProjectModel> Class_ProjectModel { get;set; }

        public async Task OnGetAsync()
        {
            Class_ProjectModel = await _context.Class_ProjectModel.ToListAsync();
        }
    }
}
