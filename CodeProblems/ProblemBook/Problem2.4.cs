﻿using System;

namespace CodeProblems.ProblemBook {
    public class Problem2_4 : ProblemBase {
        public override double Number { get; set; } = 2.4;

        public override void Execute() {
            Console.WriteLine("LINQ Problems");
            Console.WriteLine($"{nameof(Problem2_4)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(Problem2_4)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}