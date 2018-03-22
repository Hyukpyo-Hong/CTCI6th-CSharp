namespace CrackingTheCode6th {
    public abstract class Quiz {
        abstract public void Test ();
        public void Run () {
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine(Name);            
            this.Test();
        }
        public string Name => GetType ().ToString ();

    }
}