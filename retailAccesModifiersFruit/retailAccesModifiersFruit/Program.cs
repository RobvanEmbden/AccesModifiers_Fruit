using System;

namespace retailAccesModifiersFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            Coords c1 = new Coords();
            c1.x = 100;
            c1.y = 500;
            Coords c2 = c1;
            Console.WriteLine(c2.x + c2.y);
            // public - acces isn't restricted
            // private acces is restricted to the containing class (local)
            // proteced - acces is restricted to the containing class
            // internal - acces is restricted to code in the same assembly (dll or exe)
            // protected internal - combination of proteced and internal
        }
    }
    public struct Coords // became public as private won't run, which has to be within the class above.
    {
        public double x, y;
    }
}
