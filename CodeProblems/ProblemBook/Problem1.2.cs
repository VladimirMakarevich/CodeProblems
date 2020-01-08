using System;

namespace CodeProblems.ProblemBook {
    public class Problem1_2 : ProblemBase {
        public override void Execute() {
            Console.WriteLine("Object-oriented programming Problems");
            Console.WriteLine($"{nameof(Problem1_2)} start >>>>>>>>>>>> ");

            new Bar().Qux(42);
            new Baz().Qux(42);

            Console.WriteLine($"\nPress key to continuous {nameof(Problem1_2)} >>> ");
            Console.ReadLine();

            this.Write(1.0, 1);
            this.Write(1, 1.0);
            // this.Write(1, 1); error

            Console.WriteLine($"{nameof(Problem1_2)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }

        private void Write(int х, double у) {
        }

        private void Write(double x, int y) {
        }

        private class Foo {
            public virtual void Qux(int a) {
                Console.WriteLine("Foo.Qux(int)");
            }
        }

        private class Bar : Foo {
            public override void Qux(int a) {
                Console.WriteLine("Bar.Qux(int)");
            }

            public void Qux(object a) {
                Console.WriteLine("Bar.Qux(object)");
            }
        }

        private class Baz : Bar {
            public override void Qux(int a) {
                Console.WriteLine("Baz.Qux(int)");
            }

            public void Qux<T>(params T[] a) {
                Console.WriteLine("Baz.Qux(params T[])");
            }
        }
    }
}