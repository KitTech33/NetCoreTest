using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Inventory
{
    public class Category : NamedEntity
    {
        public string Description { get; set; }
    }
}
