using System;

namespace CodeProblems.ProblemBook {
    public class Problem1_1 : ProblemBase {
        public override void Execute() {
            Console.WriteLine("Object-oriented programming Problems");
            Console.WriteLine($"{nameof(Problem1_1)} start >>>>>>>>>>>> ");

            Foo();
            Foo(null);
            Foo(new Bar());
            Foo(new Bar(), new Bar());
            Foo(new Bar(), new object());

            // custom
            Foo(new object());
            Foo(1);
            Foo(string.Empty);

            Console.WriteLine($"{nameof(Problem1_1)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }

        private static void Foo(object a) {
            Console.WriteLine("object");
        }

        private static void Foo(object a, object b) {
            Console.WriteLine("object, object");
        }

        private static void Foo(params object[] args) {
            Console.WriteLine("params object[]");
        }

        private static void Foo<T>(params T[] args) {
            Console.WriteLine("params T[]");
        }

        private class Bar {
        }
    }
}