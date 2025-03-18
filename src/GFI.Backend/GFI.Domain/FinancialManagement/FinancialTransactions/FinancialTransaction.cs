using GFI.Domain.Commom.Entities;
using GFI.Domain.Commom.Enums;
using GFI.Domain.FinancialManagement.Budgets;
using GFI.Domain.FinancialManagement.ReasonsForFinancialTransactions;
using GFI.Domain.FinancialManagement.TransactionTypes;

namespace GFI.Domain.FinancialManagement.FinancialTransactions;

public class FinancialTransaction : Entity
{
    public Periodicity Periodicity { get; private set; } = default!;
    public FinancialTransactionType FinancialTransactionType { get; private set; } = default!;
    public decimal Value { get; private set; } = default!;
    public int? Installment { get; private set; } = default!;
    public int? Installments { get; private set; } = default!;
    public Guid BudgetId { get; private set; } = default!;
    public Guid ReasonForFinancialTransactionId { get; private set; } = default!;
    public Guid TransactionTypeId { get; set; }
    public Budget Budget { get; private set; } = default!;
    public ReasonForFinancialTransaction ReasonForFinancialTransaction { get; private set; } = default!;
    public TransactionType TransactionType { get; private set; } = default!;
}
