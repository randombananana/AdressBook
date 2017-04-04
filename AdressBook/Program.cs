using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            ChangeAdressBook z = new ChangeAdressBook();
            Calculator x = new Calculator();

            while (true)
            {
                Console.WriteLine("Enter 1 for ADD and 2 for Search");

                string p = Console.ReadLine();

                int t = int.Parse(p);

                switch (t)
                {
                    case 1:
                        z.Add();
                        break;
                    case 2:
                        Console.WriteLine("Enter any name to search");
                        string q = Console.ReadLine();
                        z.Search(q);
                        break;
                }
            }
     
        }            
        public void Introduce()
        {
            Console.WriteLine("Hello my name is Jesse!");
        }        
    }      
}