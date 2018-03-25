using System;
using System.Collections.Generic;
using CrackingTheCode6th.Chapter1;
namespace CrackingTheCode6th
{
    class Program
    {
        static void Main(string[] args)
        {                     
            IList<Quiz> quizs = new List<Quiz>();
            quizs.Add(new Q1_1());
            quizs.Add(new Q1_2());
            quizs.Add(new Q1_3());
            quizs.Add(new Q1_4());
            quizs.Add(new Q1_5());
            quizs.Add(new Q1_6());
            quizs.Add(new Q1_7());
            quizs.Add(new Q1_8());
            quizs.Add(new Q1_9());
            
            foreach(Quiz q in quizs){
                q.Run();
            }

        }
    }
}
