using GFI.Domain.Commom.Enums;

namespace GFI.Domain.Commom.Entities;

public abstract class Person
{
    protected Person(DocumentType documentType, string document)
    {
        DocumentType = documentType;
        Document = document;
    }

    public required DocumentType DocumentType { get; set; } = default!;
    public required string Document { get; set; } = default!;
}
