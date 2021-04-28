using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;

namespace Test.Data
{
    class DataBase_Quotes
    {
        public DataBase_Quotes()
        {
            List<Quotes> items = new List<Quotes>
            {
                new Quotes{Philosopher = "Aristotel", Quote = "Knowing yourself is the beginning of all wisdom."},
                new Quotes{Philosopher = "Aristotel", Quote = "Hope is a waking dream."},
                new Quotes{Philosopher = "Aristotel", Quote = "We are what we repeatedly do. Excellence, then, is not an act, but a habit."},
                new Quotes{Philosopher = "Aristotel", Quote = "No great genius has existed without some touch of madness."},
                new Quotes{Philosopher = "Aristotel", Quote = "Pleasure in the job puts perfection in the work."},
                new Quotes{Philosopher = "Aristotel", Quote = "The energy of the mind is the essence of life."}
            };
            using (var conn = new SQLiteConnection(Constants.DatabasePath))
            {
                conn.CreateTable<Quotes>();
                foreach (Quotes element in items)
                {
                 //   conn.Insert(element);
                }
            }
        }
    }
}