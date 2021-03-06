﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Company_Project_Expenses_Core_Web.BusinessLayer;
using Company_Project_Expenses_Core_Web.Models;

namespace Company_Project_Expenses_Core_Web.Pages.ProjectManagers
{
    //Updates the project manager 
    public class EditModel : PageModel
    {
        private readonly Company_Project_Expenses_Core_Web.Models.Company_Project_Expenses_DataContext _context;

        public EditModel(Company_Project_Expenses_Core_Web.Models.Company_Project_Expenses_DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProjectManager ProjectManager { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProjectManager = await _context.ProjectManager.FirstOrDefaultAsync(m => m.Id == id);

            if (ProjectManager == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProjectManager).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectManagerExists(ProjectManager.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProjectManagerExists(int id)
        {
            return _context.ProjectManager.Any(e => e.Id == id);
        }
    }
}
