using System;

namespace CodeProblems.ProblemBook {
    public class ProblemN : ProblemBase {
        public override void Execute() {
            Console.WriteLine($"\n{nameof(ProblemN)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(ProblemN)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}