using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp4task
{
    class Antenna
    {
        public double diameter { get; set; }
        public string material { get; set; }
        public double price { get; set; }

        public Antenna(double diameter, string material, double price)
        {
            this.diameter = diameter;
            this.material = material;
            this.price = price;
        }

        public virtual double GetQuantity()
        {
            return diameter / price;
        }

        public virtual void Print()
        {
            Console.Write($"diameter: {diameter}, material: {material}, " +
                $"price: {price}, Q: {GetQuantity()}\n");
        }
    }
}