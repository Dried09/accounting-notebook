using System;

namespace AccountingNotebook.Core.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
