using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    abstract class  Person
    {
        private string name;
        private string surname;

        public Person()
        {
            name = surname = null;
        }
        public Person(string n, string s)
        {
            name = n;
            surname = s;
        }
        public String Name
        {
            set { name = value; }
            get { return name; }
        }
        public String Surname
        {
            set { surname = value; }
            get { return surname; }
        }
        public abstract double calcPay();
    }
}
