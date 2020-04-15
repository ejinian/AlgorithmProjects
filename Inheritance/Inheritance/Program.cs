using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion();
            lion.SetWord("Grrrrrr");
            lion.SetName("Lion");
            lion.SetType("Carnivor");
            lion.SetNumberOfClaws(10);
            lion.Describe();
            lion.Talk();

            Console.ReadLine();
        }
    }
}
