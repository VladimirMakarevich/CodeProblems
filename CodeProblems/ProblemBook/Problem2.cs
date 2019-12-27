using System;

namespace CodeProblems.ProblemBook {
    public class Problem2 : ProblemBase {
        public override void Execute() {
            new Bar().Qux(42);
            new Baz().Qux(42);
            Console.ReadLine();

            this.Write(1, 1);
        }

        void Write(int х, double у) {

        }

        void Write(double x, int y) {

        }


    }

    public class Foo {
        public virtual void Qux(int a) {
            Console.WriteLine("Foo.Qux(int)");
        }
    }

    public class Bar : Foo {
        public override void Qux(int a) {
            Console.WriteLine("Bar.Qux(int)");
        }

        public void Qux(object a) {
            Console.WriteLine("Bar.Qux(object)");
        }
    }

    public class Baz : Bar {
        public override void Qux(int a) {
            Console.WriteLine("Baz.Qux(int)");
        }

        public void Qux<T>(params T[] a) {
            Console.WriteLine("Baz.Qux(params T[])");
        }
    }
}