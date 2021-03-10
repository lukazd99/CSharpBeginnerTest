using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBeginnerTest
{
    public class Answers
    {
        private static readonly Answers _instance = new Answers();
        public static Answers GetInstance() { return _instance; }
       
        private Dictionary<string, int> answers;
        public Dictionary<string, int> GetAnswers() { return answers; }

        private Answers()
        {
            answers = new Dictionary<string, int>();
            #region ADD_ANSWERS_MANUALLY
                answers.Add("", 2);
                answers.Add("", 2);
                answers.Add("", 3);
                answers.Add("", 2);
                answers.Add("", 3);
                answers.Add("", 3);
                answers.Add("", 2);
                answers.Add("", 3);
                answers.Add("", 1);
                answers.Add("", 1);
                answers.Add("", 3);
                answers.Add("", 3);
                answers.Add("", 2);
                answers.Add("", 1);
                answers.Add("", 4);
                answers.Add("", 4);
                answers.Add("", 2);
                answers.Add("", 1);
                answers.Add("", 2);
                answers.Add("", 4);
                answers.Add("", 3);
                answers.Add("", 2);
                answers.Add("", 4);
                answers.Add("", 2);
                answers.Add("", 3);
            #endregion
        }
    }
}
