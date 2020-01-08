using System;

namespace CodeProblems.ProblemBook {
    public class Problem1_5 : ProblemBase {
        public override void Execute() {
            Console.WriteLine("Object-oriented programming Problems");
            Console.WriteLine($"{nameof(Problem1_5)} start >>>>>>>>>>>> ");

            Foo<int>.Bar++;
            Console.WriteLine(Foo<double>.Bar);

            Console.WriteLine($"{nameof(Problem1_5)} end <<<<<<<<<<<< \n");
            Console.WriteLine("End of the Object-oriented programming Problems\n\n");
            Console.ReadKey();
        }

        public class Foo<T> {
            public static int Bar;
        }
    }
}