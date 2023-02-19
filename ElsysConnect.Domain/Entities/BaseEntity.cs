using System;
using System.Collections.Generic;
using System.Text;

namespace ElsysConnect.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
