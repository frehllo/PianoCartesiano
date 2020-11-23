using PianoCartesiano;
using System;

namespace PianoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto3D punto = new Punto3D(1, 2, 3);
            Console.WriteLine("x = " + punto.X);
            Console.WriteLine("y = " + punto.Y);
            Console.WriteLine("z = " + punto.Z);
        }
    }
}
