using System;

namespace CodeProblems.ProblemBook {
    public class Problem3 : ProblemBase {
        public override void Execute() {
            new Baz();

            Console.ReadLine();
        }
    }

    public class Foo {
        public Foo() {
            Qux();
        }

        public virtual void Qux() {
            Console.WriteLine("Foo.Qux()");
        }
    }

    public class Bar : Foo {
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

    public class Baz : Bar {
        public Baz() {
            name = "Baz";
            Qux();
            ((Foo) this).Qux();
        }
    }
}