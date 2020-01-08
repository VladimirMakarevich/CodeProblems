using System;

namespace CodeProblems.ProblemBook {
    public class Problem2_6 : ProblemBase {
        public override double Number { get; set; } = 2.6;

        public override void Execute() {
            Console.WriteLine("LINQ Problems");
            Console.WriteLine($"{nameof(Problem2_6)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(Problem2_6)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}