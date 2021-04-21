using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Models
{
    public class Questions
    {
        public Questions(string questions)
        {
            this.the_question = questions;
        }
        public string The_Question()
        {
            return this.the_question;
        }
        private string the_question { set; get; }
    }
}
