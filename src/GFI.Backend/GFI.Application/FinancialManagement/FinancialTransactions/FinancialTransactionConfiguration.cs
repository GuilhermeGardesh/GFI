using GFI.Domain.FinancialManagement.FinancialTransactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GFI.Application.FinancialManagement.FinancialTransactions;

public class FinancialTransactionConfiguration : IEntityTypeConfiguration<FinancialTransaction>
{
    public void Configure(EntityTypeBuilder<FinancialTransaction> builder)
    {
        builder.ToTable("FinancialTransactions");

        builder
            .Property(f => f.Periodicity)
            .IsRequired();

        builder.Property(f => f.Value)
            .IsRequired();

        builder.Property(f => f.TransactionTypeId)
            .IsRequired();
    }
}
