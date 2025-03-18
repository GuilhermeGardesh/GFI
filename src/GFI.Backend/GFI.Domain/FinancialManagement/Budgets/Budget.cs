using GFI.Domain.Commom.Entities;
using GFI.Domain.FinancialManagement.FinancialTransactions;

namespace GFI.Domain.FinancialManagement.Budgets;

public class Budget : Entity
{
    public Budget() { }

    public Budget(Guid id, Guid userId) : base(id)
    {
        UserId = userId;
    }

    public string Name { get; private set; } = default!;
    public DateTime InitialDate { get; private set; } = default!;
    public DateTime FinalDate { get; private set; } = default!;
    public List<FinancialTransaction> FinancialTransactions { get; private set; } = default!;
    public Guid UserId { get; private set; }

    public void SetAutomaticallyName()
    {
        Name = $"{InitialDate} - {FinalDate}";
    }

    public void SetDates()
    {
        InitialDate = DateTime.Now.Date;
        FinalDate = DateTime.Now.AddMonths(1);
    }
}
