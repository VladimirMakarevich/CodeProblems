using System;

namespace CodeProblems.ProblemBook {
    public class Problem1_4 : ProblemBase {
        public override double Number { get; set; } = 1.4;

        public override void Execute() {
            Console.WriteLine("Object-oriented programming Problems");
            Console.WriteLine($"{nameof(Problem1_4)} start >>>>>>>>>>>> ");

            new Baz();

            Console.WriteLine($"{nameof(Problem1_4)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }

        private class Foo {
            public Foo() {
                Qux();
            }

            public virtual void Qux() {
                Console.WriteLine("Foo.Qux()");
            }
        }

        private class Bar : Foo {
            protected string name;

            public Bar() {
                name = "Bar";
            }

            public override void Qux() {
                Console.WriteLine("Bar.Qux(), " + name);
            }

            public void Qux(params object[] args) {
                Console.WriteLine("Bar.Qux(params object[])");
            }
        }

        private class Baz : Bar {
            public Baz() {
                name = "Baz";
                Qux();
                ((Foo) this).Qux();
            }
        }
    }
}