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
                new Quotes{Philosopher = "Aristotel", Quote = "Knowing yourself is the beginning of all wisdom.", Philosophy = "Stoicism"},
                new Quotes{Philosopher = "Aristotel", Quote = "Hope is a waking dream.", Philosophy = "Stoicism"},
                new Quotes{Philosopher = "Aristotel", Quote = "We are what we repeatedly do. Excellence, then, is not an act, but a habit.",Philosophy = "Stoicism"},
                new Quotes{Philosopher = "Aristotel", Quote = "No great genius has existed without some touch of madness.",Philosophy = "The greeks"},
                new Quotes{Philosopher = "Aristotel", Quote = "Pleasure in the job puts perfection in the work.",Philosophy="Taoism",Favorite="true"},
                new Quotes{Philosopher = "Aristotel", Quote = "The energy of the mind is the essence of life.",Philosophy="Taoism",Favorite="true"}
            };
            List<Philosophers> item_philosopher = new List<Philosophers>
            {
                new Philosophers{Philosopher = "Aristotel", Philosophy = "The greeks"},
                new Philosophers{Philosopher = "Lao Tzu", Philosophy = "Taoism"},
                new Philosophers{Philosopher = "Marcus Aurelius", Philosophy = "Stoicism"}
            };
            using (var conn = new SQLiteConnection(Constants.DatabasePath))
            {
                conn.CreateTable<Quotes>();
                foreach (Quotes element in items)
                {
                    conn.Insert(element);
                }
                conn.CreateTable<Philosophers>();
                foreach (Philosophers element in item_philosopher)
                {
                 //   conn.Insert(element);
                }
            }
        }
    }
}