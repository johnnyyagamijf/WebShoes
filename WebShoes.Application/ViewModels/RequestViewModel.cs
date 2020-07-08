using System;
using System.Collections.Generic;
using System.Text;
using WebShoes.Core.Entities;

namespace WebShoes.Application.ViewModels
{
    public class RequestViewModel
    {
        public int Id { get; set; }
        public double Total { get; set; }

        public DateTime Date { get; set; }
        public int ProductId { get; set; }

        public ProductEntity Product { get; set; }
    }
}
