using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Test.Models
{
    public class Quotes
    {
        public Quotes()
        {
            
        }
        public string Quote { get; set; }
        public string Philosopher { get; set; }
        public string Philosophy { get; set; }
        public string Favorite { get; set; }
    }
}
