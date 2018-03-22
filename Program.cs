using System;
using System.Collections.Generic;
using CrackingTheCode6th.Chapter1;
namespace CrackingTheCode6th
{
    class Program
    {
        static void Main(string[] args)
        {           
            Quiz q1_1 = new Q1_1();
            IList<Quiz> quizs = new List<Quiz>();
            quizs.Add(new Q1_1());
            quizs.Add(new Q1_2());
            
            foreach(Quiz q in quizs){
                q.Run();
            }

        }
    }
}
