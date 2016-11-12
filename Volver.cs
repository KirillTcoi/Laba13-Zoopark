using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
   public class Volver
    {
        public int Id { get; set; }
        public Zver Zver { get; set; }
        public Zoopark Zoopark { get; set; }

        private Volver()
        { }
        public Volver(Zoopark zoo)
        {
            Zoopark = zoo;
        }
      
    }
}
