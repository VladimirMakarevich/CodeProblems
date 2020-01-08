using System;

namespace CodeProblems.ProblemBook {
    public class Problem2_11 : ProblemBase {
        public override double Number { get; set; } = 2.11;

        public override void Execute() {
            Console.WriteLine("LINQ Problems");
            Console.WriteLine($"{nameof(Problem2_11)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(Problem2_11)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}