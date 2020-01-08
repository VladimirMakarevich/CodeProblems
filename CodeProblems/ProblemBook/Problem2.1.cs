using System;

namespace CodeProblems.ProblemBook {
    public class Problem2_1 : ProblemBase {
        public override double Number { get; set; } = 2.1;

        public override void Execute() {
            Console.WriteLine("LINQ Problems\n\n");
            Console.WriteLine($"{nameof(Problem2_1)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(Problem2_1)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}