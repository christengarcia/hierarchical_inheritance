﻿using System;

namespace hierarchical_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal g = new Principal();
            g.Monitor();
            Teacher d = new Teacher();
            d.Monitor();
            d.Teach();
            Student s = Student();
            s.Monitor();
            Console.ReadKey();
        }
    }
}