using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    class Properties
    {
        private string name;
        private string city;
        private string country;

        public Properties(string a, string b, string c)
        {
            this.name = a;
            this.city = b;
            this.country = c;
            
        }
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        
    }
}
