using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company_Project_Expenses_Core_Web.BusinessLayer
{
    public class Expense
    {

        public int Id { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public int ProjectManagerId { get; set; }

        public ProjectManager ProjectManager { get; set; }


        public string ExpenseDescription { get; set; }

        public decimal SpentAmount { get; set; }


    }
}
