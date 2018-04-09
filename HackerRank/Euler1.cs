using System;

namespace CrackingTheCode6th.HackerRank {
    public class Euler1 : Quiz {
        public override void Test () {

            int n = 1000000000;
            long result = 0;
            result += Caculate (3, n);
            result += Caculate (5, n);
            result -= Caculate (15, n);

            Console.WriteLine (result);

        }

        private long Caculate (int multiple, long maxNumber) {
            long endIdx = (maxNumber-1) / multiple;
            long result = 0;
            if (endIdx % 2 == 0) {
                result = multiple * (1 + endIdx) * (endIdx / 2);
            } else {
                int numberOfMutiple = (int)Math.Floor((double)endIdx/2.0);            
                int middle = (int)Math.Ceiling((double)endIdx / 2.0);
                result = multiple * (((1 + endIdx)*numberOfMutiple) + middle );
            }

            return result;
        }
    }
}