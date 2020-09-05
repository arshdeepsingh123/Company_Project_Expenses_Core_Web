using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Company_Project_Expenses_Core_Web.BusinessLayer;

namespace Company_Project_Expenses_Core_Web.Models
{
    //Links the database with the business logic layer
    public class Company_Project_Expenses_DataContext : DbContext
    {
        public Company_Project_Expenses_DataContext (DbContextOptions<Company_Project_Expenses_DataContext> options)
            : base(options)
        {
        }

        public DbSet<Company_Project_Expenses_Core_Web.BusinessLayer.Company> Company { get; set; }

        public DbSet<Company_Project_Expenses_Core_Web.BusinessLayer.Expense> Expenses { get; set; }

        public DbSet<Company_Project_Expenses_Core_Web.BusinessLayer.ProjectManager> ProjectManager { get; set; }

        public DbSet<Company_Project_Expenses_Core_Web.BusinessLayer.Project> Project { get; set; }
    }
}
