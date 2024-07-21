using Psi.Domain.Enums;
using Psi.Domain.Models.Documents;

namespace Psi.Api.Requests.Documents
{
   public class DocumentRequest
   {
      public DocumentType Type { get; set; }
      public string Value { get; set; }

      internal Document ToDocument()
      {
         return new Document(Type, Value);
      }
   }
}
