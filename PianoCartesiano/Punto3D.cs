using System;
using System.Collections.Generic;
using System.Text;

namespace PianoCartesiano
{
    public class Punto3D : Punto
    {
        public  int Z { get; set; }

        public Punto3D(int x, int y,  int z) : base(x,y)
        {
            Z = z;
        }
    }
}
