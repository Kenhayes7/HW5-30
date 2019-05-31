using System;
using System.Collections.Generic;
using System.Text;

namespace HW5_30
{
    public class fruit
    {
        public string _seeds { set; get; }
        public int _juicy { set; get; }

        public fruit(string seeds, int juicy)
        {
            
            _seeds = seeds;
            _juicy = juicy;
            Console.WriteLine("Let's Talk about fruit");
        }

        public void juiceLevel(int juicy, string seeds)
        {
            Console.WriteLine("the juicy level is {0}", _juicy);
            Console.WriteLine("this fruit has {0}", _seeds);
        }
    }

    public class strawBerry : fruit
    {
        public string _name { set; get; }
        public int _many { set; get; }

        public strawBerry(string seeds, int juicy, int many) : base(seeds, juicy)
        {
            _seeds = seeds;
            _juicy = juicy;
            _name = "Mango";

        }

        public void ripe(string ripe)
        {
            Console.WriteLine("the {0} is {1}", _name, ripe);
        }
    }
}
