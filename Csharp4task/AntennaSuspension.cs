using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp4task
{
    class AntennaSuspension : Antenna
    {
        public Suspension susp;

        public AntennaSuspension(double diameter, string material, double price, Suspension susp)
                            : base(diameter, material, price)
        {
            this.susp = susp;
        }

        public override double GetQuantity()
        {
            double q = base.GetQuantity();
            if (susp == Suspension.Azimuthal)
                return q;
            else if (susp == Suspension.Polar)
                return 2 * q;
            else
                return 2.5 * q;

        }

        public override void Print()
        {
            Console.Write($"diameter: {diameter}, material: {material}, " +
                $"price: {price}, suspension: {susp}, Qp: {GetQuantity()}\n");
        }
    }
}

enum Suspension
{
    Azimuthal,
    Polar,
    Toroidal
}