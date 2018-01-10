using System;

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

        class Principal
        {
            public void Monitor()
            {
                Console.WriteLine("Monitor");
            }
        }

        class Teacher : Principal
        {
            public void Teach()
            {
                Console.WriteLine("Teach");
            }
        }


    }
}
