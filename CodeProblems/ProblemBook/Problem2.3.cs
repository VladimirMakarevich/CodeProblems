﻿using System;

namespace CodeProblems.ProblemBook {
    public class Problem2_3 : ProblemBase {
        public override double Number { get; set; } = 2.3;

        public override void Execute() {
            Console.WriteLine("LINQ Problems");
            Console.WriteLine($"{nameof(Problem2_3)} start >>>>>>>>>>>> ");

            Console.WriteLine($"{nameof(Problem2_3)} end <<<<<<<<<<<< \n");
            Console.ReadKey();
        }
    }
}