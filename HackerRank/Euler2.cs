namespace CrackingTheCode6th.HackerRank {
    public class Euler2 : Quiz {
        public override void Test () {
            long N = 40000000000000000;
            long first = 1;
            long second = 2;
            long third;
            long result = 0;

            while (true) {
                third = first + second;                
                first = second;
                second = third;
                if(third>N) break;
                if(third%2==0) result+=third;                
            }
            System.Console.WriteLine(result+2);
        }
    }
}