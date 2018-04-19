using System;
using System.Collections.Generic;
using CrackingTheCode6th.Chapter1;
using CrackingTheCode6th.Chapter2;
using CrackingTheCode6th.Chapter3;
using CrackingTheCode6th.Chapter4;
using CrackingTheCode6th.DataStructure;
using CrackingTheCode6th.HackerRank;
using CrackingTheCode6th.PracticeForRef;
using CrackingTheCode6th.Sort;

namespace CrackingTheCode6th {
    class Program {
        static void Main (string[] args) {
            IList<Quiz> quizzes = new List<Quiz> ();
            //AddChapter1 (quizzes);
            //AddChapter2 (quizzes);
            //AddChapter3 (quizzes);
            AddChapter4 (quizzes);
            
            //AddHackerRank(quizzes);
            

            foreach (Quiz q in quizzes) {
                q.Run ();
            }
        }

        private static void AddHackerRank(IList<Quiz> quizzes)
        {            
            //quizzes.Add(new JourneytotheMoon());
            //quizzes.Add(new RoadsandLibraries());
            quizzes.Add(new BirthdayChocolate());
            //quizzes.Add(new Euler1());
            //quizzes.Add(new Euler2());
            quizzes.Add(new Euler3());
            
        }

        private static void AddChapter4 (IList<Quiz> quizzes) {
            quizzes.Add (new Q4_1 ());
            quizzes.Add (new Q4_2 ());
            quizzes.Add (new Q4_3 ());
            quizzes.Add (new Q4_4 ());
            quizzes.Add (new Q4_5 ());
            quizzes.Add (new Q4_6 ());
        }

        private static void AddChapter3 (IList<Quiz> quizzes) {
            quizzes.Add (new Q3_1 ());
            quizzes.Add (new Q3_2 ());
            quizzes.Add (new Q3_3 ());
            quizzes.Add (new Q3_4 ());
            quizzes.Add (new Q3_5 ());
            quizzes.Add (new Q3_6 ());
        }
        private static void AddChapter2 (IList<Quiz> quizzes) {
            quizzes.Add (new Q2_1 ());
            quizzes.Add (new Q2_2 ());
            //quizzes.Add (new Q2_3 ());
            quizzes.Add (new Q2_4 ());
            quizzes.Add (new Q2_5 ());
            quizzes.Add (new Q2_6 ());
            quizzes.Add (new Q2_7 ());
            quizzes.Add (new Q2_8 ());
        }

        private static void AddChapter1 (IList<Quiz> quizzes) {
            quizzes.Add (new Q1_1 ());
            quizzes.Add (new Q1_2 ());
            quizzes.Add (new Q1_3 ());
            quizzes.Add (new Q1_4 ());
            quizzes.Add (new Q1_5 ());
            quizzes.Add (new Q1_6 ());
            quizzes.Add (new Q1_7 ());
            quizzes.Add (new Q1_8 ());
            quizzes.Add (new Q1_9 ());
        }

    }
}