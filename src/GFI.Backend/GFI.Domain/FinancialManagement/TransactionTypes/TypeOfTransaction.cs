using GFI.Domain.Commom.Entities;
using GFI.Domain.FinancialManagement.FinancialTransactions;

namespace GFI.Domain.FinancialManagement.TransactionTypes
{
    public class TransactionType : Entity
    {
        public string Name { get; private set; } = default!;
        public List<FinancialTransaction> FinancialTransaction { get; private set; } = default!;
        //TODO: Aqui deve haver um arquivo de imagem do icone do tipo de transaction
    }
}
