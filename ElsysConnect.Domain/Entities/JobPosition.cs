using System;
using System.Collections.Generic;

namespace ElsysConnect.Domain.Entities
{
    public class JobPosition : BaseEntity
    {
        public string Title { get; set; }
        public DateTime? ClosingDate { get; set; }
    }
}

