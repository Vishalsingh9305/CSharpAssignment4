using System;

namespace Assignment4
{
    internal class Product
    {
        public int PId { get; set; }
        public string Pname { get; set; }
        public int Pqty { get; set; }
        public static string Pbrand { get; set; }
        public double Pdiscount { get; set; }

        public Product()
        {
        }

        public Product(int pid, string name, int quantity, double discount)
        {
            PId = pid;
            Pname = name;
            Pqty = quantity;
            Pdiscount = discount;
        }

        public override string ToString()
        {
            return $"Pcode:{PId}, Name:{Pname}, Brand:{Pbrand}, Quantity:{Pqty}, Discount:{Pdiscount}";
        }
    }
}
