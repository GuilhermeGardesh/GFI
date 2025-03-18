using GFI.Domain.FinancialManagement.ReasonsForFinancialTransactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GFI.Application.FinancialManagement.ReasonsForFinancialTransactions;

public class ReasonForFinancialTransactionConfiguration : IEntityTypeConfiguration<ReasonForFinancialTransaction>
{
    public void Configure(EntityTypeBuilder<ReasonForFinancialTransaction> builder)
    {
        builder.ToTable("ReasonsForFinancialTransactions");

        builder
            .HasIndex(r => r.Name)
            .IsUnique();
        builder
            .Property(r => r.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder
            .HasMany(b => b.FinancialTransaction)
            .WithOne(f => f.ReasonForFinancialTransaction);
    }
}
