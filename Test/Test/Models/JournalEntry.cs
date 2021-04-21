﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Test.Models
{
    public class JournalEntry
    {
      //  public JournalEntry(string title, string writings)
     //   {
      //      this.Title = title;
      //      this.Writings = writings;
      //      CreateAt = DateTime.Now;
      //  }
      public JournalEntry()
        {
            CreateAt = DateTime.Now;
        }
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Title {  get; set; }
        public string Writings { get; set; }
        public DateTime CreateAt { get; set; }
    }
}