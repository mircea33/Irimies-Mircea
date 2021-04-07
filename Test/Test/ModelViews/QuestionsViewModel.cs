using System;
using System.Collections.Generic;
using System.Text;
using Test.Models;
namespace Test.ModelViews
{
    public class QuestionsViewModel
    {
        public List<Questions> questions = new List<Questions>();
        public QuestionsViewModel()
        {
            questions.Add(new Questions("What is life ?"));
            questions.Add(new Questions("How is life going ?"));
            questions.Add(new Questions("what is the meaning of this?"));
        }
    }
}
