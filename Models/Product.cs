using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Real_Time_CRUD_Operations_SignalR.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockQty { get; set; }
    }
}
