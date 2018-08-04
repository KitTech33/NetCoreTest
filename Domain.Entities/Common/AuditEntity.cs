using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Common
{
    public class AuditEntity : BaseEntity
    {
        public string CreatedBy { get; set; }
        public string LastEditedBy { get; set; }
        public DateTime LastEditedOn { get; set; }
    }
}
