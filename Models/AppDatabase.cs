using System.Data.Entity;

namespace Samjee.Models
{
    public class AppDatabase : DbContext
    {
        public AppDatabase() : base("Data Source=Samjee.db")
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
