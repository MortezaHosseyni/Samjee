using System.Data.Entity;

namespace Samjee.Models
{

    public class AppDatabase : DbContext
    {
        public AppDatabase() : base("DbConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AppDatabase>());
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transaction>()
                        .HasMany(t => t.Incomes)
                        .WithRequired(i => i.Transaction)
                        .HasForeignKey(i => i.IN_Transaction);

            modelBuilder.Entity<Transaction>()
                        .HasMany(t => t.Expenses)
                        .WithRequired(e => e.Transaction)
                        .HasForeignKey(e => e.EX_Transaction);
        }
    }
}
