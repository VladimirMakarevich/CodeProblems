using System;

namespace CodeProblems.ProblemBook {
    public class ProblemN : ProblemBase {
        public override void Execute() {
            Console.WriteLine("'Title' Problems");
            Console.WriteLine($"{nameof(ProblemN)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(ProblemN)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}