using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    class ChangeAdressBook
    {
        List<Properties> names = new List<Properties>();
        public void AddNumbers()
        {
            
            Console.WriteLine("enter your name");
            string entry1 = Console.ReadLine();

            Properties d = new Properties(entry1, "Emmeloord", "Nederland");
            names.Add(d);
            
        }

        public void Add()
        {
            Console.WriteLine("Enter your name");
            string m = Console.ReadLine();

            Properties d = new Properties(m, "Emmeloord", "Nederland");
            names.Add(d);
        }
        public void Search(string l)
        {
            for(int i = 0; i < names.Count; i++)
            {
                Properties z = names[i];
                string v = z.Name;
                if (v.Equals(z.Name))
                {
                    Console.WriteLine(z.Name);
                }
            }
        }
        

    }
}
