﻿using System;

namespace CodeProblems.ProblemBook {
    public class Problem2_7 : ProblemBase {
        public override double Number { get; set; } = 2.7;

        public override void Execute() {
            Console.WriteLine("LINQ Problems");
            Console.WriteLine($"{nameof(Problem2_7)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(Problem2_7)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}