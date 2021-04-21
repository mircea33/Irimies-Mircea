using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Test.Models
{
    public class Philosophy
    {
        public Philosophy(string nume)
        {
            this.Name = nume;
        }
        [PrimaryKey]
        public string Name {set; get; }
    }
}
