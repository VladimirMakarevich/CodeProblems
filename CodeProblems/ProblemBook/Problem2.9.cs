using System;

namespace CodeProblems.ProblemBook {
    public class Problem2_9 : ProblemBase {
        public override double Number { get; set; } = 2.9;

        public override void Execute() {
            Console.WriteLine("LINQ Problems");
            Console.WriteLine($"{nameof(Problem2_9)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(Problem2_9)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}