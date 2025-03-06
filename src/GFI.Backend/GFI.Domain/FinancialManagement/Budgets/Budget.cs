using GFI.Domain.Commom.Entities;
using GFI.Domain.FinancialManagement.FinancialTransactions;

namespace GFI.Domain.FinancialManagement.Budgets;

public class Budget : Entity
{
    public Budget() { }

    public DateOnly InitialDate { get; private set; } = default!;
    public DateOnly FinalDate { get; private set; } = default!;
    public List<FinancialTransaction> FinancialTransactions { get; private set; } = default!;
}
