using System;

namespace CodeProblems.ProblemBook {
    public class ProblemN : ProblemBase {
        public override double Number { get; set; } = 0;

        public override void Execute() {
            Console.WriteLine("'Title' Problems");
            Console.WriteLine($"{nameof(ProblemN)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(ProblemN)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}