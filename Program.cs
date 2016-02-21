using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppCSNameAndTime
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Please enter your name Mike:");
            string strName = Console.ReadLine();
            Console.WriteLine("Hi {0}, the current time is {1}.", strName, System.DateTime.Now.TimeOfDay);
            Console.WriteLine("To quit the program, press any key!");
            Console.ReadKey(); } }
}