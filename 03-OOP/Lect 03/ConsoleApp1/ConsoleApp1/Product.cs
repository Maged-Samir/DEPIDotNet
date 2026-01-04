using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }


        public string PrintDetails()
        {
            return $"Id: {Id}, Name: {Name}, Qty: {Qty}";
        }
    }
}
