using PianoCartesiano;
using System;

namespace PianoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto3D punto = new Punto3D(1, 2, 3);
            Console.WriteLine(punto.X);
            Console.WriteLine(punto.Y);
            Console.WriteLine(punto.Z);
        }
    }
}
