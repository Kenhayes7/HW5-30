using System;

namespace HW5_30
{
    class Program
    {
        static void Main(string[] args)
        {
            fruit F1 = new fruit("seeds", 9);
            F1.juiceLevel(9, "seeds");

            strawBerry SB1 = new strawBerry("seeds", 5, 12, "redberry");
            SB1.ripe("ripe");
        }
    }
}
