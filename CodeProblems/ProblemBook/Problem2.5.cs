using System;

namespace CodeProblems.ProblemBook {
    public class Problem2_5 : ProblemBase {
        public override double Number { get; set; } = 2.5;

        public override void Execute() {
            Console.WriteLine("LINQ Problems");
            Console.WriteLine($"{nameof(Problem2_5)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(Problem2_5)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}