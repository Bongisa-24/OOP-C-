using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    class Programmer : Person
    {
        private int hours;
        private double rate;

        public Programmer():base()
        {
            hours = 0;
            rate = 0.0;
        }
        public Programmer(string n, string s,int hrs, double r)
            : base(n,s)
        {
            hours = hrs;
            rate = r;
        }
        public int Hours
        {
            set { hours = value; }
            get { return hours; }
        }
        public double Rate
        {
            set { rate = value; }
            get { return rate; }
        }
        public override double calcPay()
        {
            return hours * rate;
        }


    }
}
