using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Models
{
    public class Philosophers
    {
        public Philosophers()
        {
            
        }
        [PrimaryKey]
        public string Philosopher{ get; set; }
        public string Philosophy{ get; set; }
    }
}
