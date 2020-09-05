using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Company_Project_Expenses_Core_Web.BusinessLayer;
using Company_Project_Expenses_Core_Web.Models;

namespace Company_Project_Expenses_Core_Web.Pages.Expenses
{
    //Gets the details of the expeses record
    public class DetailsModel : PageModel
    {
        private readonly Company_Project_Expenses_Core_Web.Models.Company_Project_Expenses_DataContext _context;

        public DetailsModel(Company_Project_Expenses_Core_Web.Models.Company_Project_Expenses_DataContext context)
        {
            _context = context;
        }

        public Expense Expense { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Expense = await _context.Expenses
                .Include(e => e.Company)
                .Include(e => e.Project)
                .Include(e => e.ProjectManager).FirstOrDefaultAsync(m => m.Id == id);

            if (Expense == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
