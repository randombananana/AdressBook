using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    class Calculator
    {
      

        public void Add()
        {
            Console.WriteLine("please enter the first number");
            int entry1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the second number");
            int entry2 = int.Parse(Console.ReadLine());

            int add = entry1 + entry2;

            Console.WriteLine(add);
        }
    }
}
