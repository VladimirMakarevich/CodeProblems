﻿using System;

namespace CodeProblems.ProblemBook {
    public class Problem2_2 : ProblemBase {
        public override double Number { get; set; } = 2.2;

        public override void Execute() {
            Console.WriteLine("LINQ Problems");
            Console.WriteLine($"{nameof(Problem2_2)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(Problem2_2)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}