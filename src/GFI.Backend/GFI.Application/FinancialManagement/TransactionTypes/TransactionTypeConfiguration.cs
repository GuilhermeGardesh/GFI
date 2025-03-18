using GFI.Domain.FinancialManagement.TransactionTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GFI.Application.FinancialManagement.TransactionTypes;

public class TransactionTypeConfiguration : IEntityTypeConfiguration<TransactionType>
{
    public void Configure(EntityTypeBuilder<TransactionType> builder)
    {
        builder.ToTable("TransactionTypes");
        builder
            .HasIndex(t => t.Name)
            .IsUnique();
        builder
            .Property(t => t.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .HasMany(t => t.FinancialTransaction)
            .WithOne(r => r.TransactionType);
    }
}

