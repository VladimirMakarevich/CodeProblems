using System;
using System.Linq;
using System.Reflection;
using CodeProblems.ProblemBook;

namespace CodeProblems {
    public class Program {
        public static void Main(string[] args) {
            var assembly = Assembly.GetAssembly(typeof(ProblemBase));
            var problems = assembly.DefinedTypes
                .Where(type => typeof(ProblemBase).GetTypeInfo()
                                   .IsAssignableFrom(type.AsType()) && !type.IsAbstract)
                .ToList();

            foreach (var problem in problems) {
                var method = typeof(ProblemBase).GetMethod("Execute");
                object classInstance = Activator.CreateInstance(problem, null);
                if (method != null && classInstance != null) {
                    method.Invoke(classInstance, null);
                }
            }

            Console.WriteLine("End of Problems");
            Console.ReadLine();
        }
    }
}