using System;
using System.Collections.Generic;
using System.Text;

namespace WebShoes.Core.Entities
{
    public class RequestEntity
    {
        public int Id { get; set; }

        public double Total { get; set; }

        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        
    }
}
