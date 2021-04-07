using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Models
{
    public class Filozofii
    {
        public Filozofii(string nume)
        {
            this.Nume = nume;
        }
        public string Nume { private set; get; }
    }
}
