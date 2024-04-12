using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string? ExpenseName { get; set; }
        public string? ExpenseAccount { get; set; }
        public string? ExpenseCategory { get; set; }
        public string? ExpenseDate { get; set; }
        public string? ExpenseComment { get; set; }
        public string? ExpenseUser { get; set; }
    }
}
