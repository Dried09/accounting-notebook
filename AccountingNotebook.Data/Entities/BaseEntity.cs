using System;

namespace AccountingNotebook.Data.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
