using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World 2!");
            Learner HelloClass = new Learner();
            HelloClass.FamilyName = "Mark";
            Console.WriteLine(HelloClass.FamilyName);
        }
    }

}


