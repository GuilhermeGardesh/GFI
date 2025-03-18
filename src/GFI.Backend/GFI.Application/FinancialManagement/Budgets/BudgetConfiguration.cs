using GFI.Domain.FinancialManagement.Budgets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GFI.Application.FinancialManagement.Budgets
{
    public class BudgetConfiguration : IEntityTypeConfiguration<Budget>
    {
        public void Configure(EntityTypeBuilder<Budget> builder)
        {
            builder.ToTable("Budgets");
            
            builder
                .HasMany(b => b.FinancialTransactions)
                .WithOne(f => f.Budget);
            
            builder
                .Property(b => b.InitialDate)
                .IsRequired();
            
            builder.Property(b => b.FinalDate).IsRequired();
        }
    }
}