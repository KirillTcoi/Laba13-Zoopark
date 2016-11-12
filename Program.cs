using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace RoevRuchei
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoopark zoo1 = new Zoopark();
            Zoopark zoo2 = new Zoopark();
            Zver z1 = new Zver { Name = "Alex", Typ = "Lion" };
            Zver z2 = new Zver { Name = "Martin", Typ = "Zebra" };
            zoo1.Volvers[0].Zver = z1;
            zoo2.Volvers[0].Zver = z2;
            Perem(zoo2, zoo1, z1);
        }
        public static void Perem(Zoopark ZB, Zoopark ZA, Zver Z)
        {
            ZB.Volvers[0].Zver = Z;
            ZA.Volvers[0].Zver = null;
        }
    }
}
