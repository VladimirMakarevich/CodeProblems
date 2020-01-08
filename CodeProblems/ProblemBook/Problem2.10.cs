using System;

namespace CodeProblems.ProblemBook {
    public class Problem2_10 : ProblemBase {
        public override double Number { get; set; } = 2.10;

        public override void Execute() {
            Console.WriteLine("LINQ Problems");
            Console.WriteLine($"{nameof(Problem2_10)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(Problem2_10)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}