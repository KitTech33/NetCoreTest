using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Inventory
{
    public class Item : NamedEntity
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quanty { get; set; }

        //public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
