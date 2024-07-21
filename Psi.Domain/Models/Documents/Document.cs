using Psi.Domain.Enums;

namespace Psi.Domain.Models.Documents;

public class Document
{
    public DocumentType Type { get; set; }
    public string Value { get; set; }

    public Document(DocumentType type, string value)
    {
        Type = type;
        Value = value;
    }
}
