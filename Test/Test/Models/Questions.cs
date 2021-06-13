using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Models
{
    public class Questions
    {
        [PrimaryKey]
        public string Question { get; set; }
    }
}
