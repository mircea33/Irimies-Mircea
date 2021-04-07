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
        public string the_question { private set; get; }
    }
}
