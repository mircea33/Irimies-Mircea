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
       // [System.ComponentModel.DataAnnotations.Schema.ForeignKey(typeof(Philosophers))]
        public string Philosopher { get; set; }
        
      //  [ManyToOne]
      //  public Philosophers Philosophers { get; set; }
    }
}
