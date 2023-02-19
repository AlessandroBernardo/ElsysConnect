using System;

namespace ElsysConnect.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
