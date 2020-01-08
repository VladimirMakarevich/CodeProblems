using System;

namespace CodeProblems.ProblemBook {
    public class Problem2_8 : ProblemBase {
        public override double Number { get; set; } = 2.8;

        public override void Execute() {
            Console.WriteLine("LINQ Problems");
            Console.WriteLine($"{nameof(Problem2_8)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(Problem2_8)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}