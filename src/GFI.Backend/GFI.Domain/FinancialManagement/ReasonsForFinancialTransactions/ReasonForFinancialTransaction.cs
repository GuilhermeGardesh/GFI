using GFI.Domain.Commom.Entities;
using GFI.Domain.Commom.Enums;
using GFI.Domain.FinancialManagement.FinancialTransactions;

namespace GFI.Domain.FinancialManagement.ReasonsForFinancialTransactions
{
    public class ReasonForFinancialTransaction : Entity
    {
        public string Name { get; private set; } = default!;
        public TypeOfDocument? typeOfDocument { get; private set; } = default!;
        public string Document { get; private set; } = default!;
        public List<FinancialTransaction> FinancialTransaction { get; private set; } = default!;

        //TODO: Aqui deve haver um arquivo de imagem do icone do tipo de transaction
    }
}
