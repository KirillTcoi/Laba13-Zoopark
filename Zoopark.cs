using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Zoopark
    {
        public List<Volver> Volvers { get; set; }

        public Zoopark()
        {
           Volvers = new List<Volver>() { new Volver(this) };
        }

    }
}
