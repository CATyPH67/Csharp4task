using System;

namespace Csharp4task
{
    class Program
    {
        static void Main(string[] args)
        {
            Antenna antenna = new Antenna(100, "железо", 1000);
            Antenna antennaAzimuthal = new AntennaSuspension(100, "железо", 1000, Suspension.Azimuthal);
            Antenna antennaPolar = new AntennaSuspension(100, "железо", 1000, Suspension.Polar);
            Antenna antennaToroidal = new AntennaSuspension(100, "железо", 1000, Suspension.Toroidal);

            Console.Write("просто антенна:\n");
            antenna.Print();
            Console.Write("\n");

            Console.Write("антенна с азимутальной:\n");
            antennaAzimuthal.Print();
            Console.Write("\n");

            Console.Write("антенна с полярной:\n");
            antennaPolar.Print();
            Console.Write("\n");

            Console.Write("антенна с тороидальной:\n");
            antennaToroidal.Print();
        }
    }
}
