using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Programmer> list = new List<Programmer>();
                                
            Programmer pro1 = new Programmer("Sam", "Pam", 5, 15.5);
            Programmer pro2 = new Programmer("Jane", "Lee", 78, 15.5);
            Programmer pro3 = new Programmer("Linda", "Jill", 200, 15.5);

            list.Add(pro1);
            list.Add(pro2);
            list.Add(pro3);


            for (int x = 0; x < list.Count; x++)
            {
                Console.WriteLine("Wages " + (x + 1) + ": R" + list[x].calcPay());
            }

            //Programmer[] programmer = new Programmer[3];
            //programmer[0] = pro1;
            //programmer[1] = pro2;
            //programmer[2] = pro3;

            //for (int x = 0; x < programmer.Length; x++ )
            //{
            //    Console.WriteLine("Wages " + (x + 1) + ": R"+programmer[x].calcPay());
            //}

                //string name;
                //Console.Write("Enter name:");
                //name = Console.ReadLine();

                //Console.WriteLine(pro.Name + " " + pro.Rate);
                //Console.WriteLine("Wages are:  R" + pro.calcPay());

                Console.ReadKey();

        }
    }
}
