using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Test.Models
{
    public class Philosophy
    {
        public Philosophy()
        {
        }
        [PrimaryKey]
        public string Name {set; get; }
    }
}
