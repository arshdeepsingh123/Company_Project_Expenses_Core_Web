using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Company_Project_Expenses_Core_Web.BusinessLayer;
using Company_Project_Expenses_Core_Web.Models;

namespace Company_Project_Expenses_Core_Web.Pages.Expenses
{
    //Creats an expenses record 
    public class CreateModel : PageModel
    {
        private readonly Company_Project_Expenses_Core_Web.Models.Company_Project_Expenses_DataContext _context;

        public CreateModel(Company_Project_Expenses_Core_Web.Models.Company_Project_Expenses_DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "CompanyName");
        ViewData["ProjectId"] = new SelectList(_context.Set<Project>(), "Id", "ProjectName");
        ViewData["ProjectManagerId"] = new SelectList(_context.Set<ProjectManager>(), "Id", "ProjectManagerName");
            return Page();
        }

        [BindProperty]
        public Expense Expense { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Expenses.Add(Expense);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
