using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraystuff
{
    class Program
    {
        static void Main(string[] args)
        {
            EArray ea = new EArray();
            ea.Add(0);
            ea.Add(1);
            ea.Add(2);
            ea.Add(3);
            ea.Add(4);
            ea.Add(5);
            ea.Add(6);
            ea.Add(7);
            ea.Add(8);
            ea.Add(9);

            //ea.PrintArray();

            ea.Delete(5);

            ea.PrintArray();

            Console.ReadLine();
        }
    }
}
