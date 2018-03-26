﻿using System;
using System.Collections.Generic;
using CrackingTheCode6th.Chapter1;
using CrackingTheCode6th.Chapter2;
using CrackingTheCode6th.Others;

namespace CrackingTheCode6th {
    class Program {
        static void Main (string[] args) {
            IList<Quiz> quizzes = new List<Quiz> ();
            //AddChapter1 (quizzes);
            //AddChapter2 (quizzes);
            AddChapter3 (quizzes);
            //AddOthers(quizzes);

            foreach (Quiz q in quizzes) {
                q.Run ();
            }
        }

        private static void AddChapter3(IList<Quiz> quizzes)
        {
        }
        private static void AddChapter2(IList<Quiz> quizzes)
        {
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

        
        private static void AddOthers(IList<Quiz> quizzes)
        {
            quizzes.Add(new CustomLinkedList());
        }
    }
}