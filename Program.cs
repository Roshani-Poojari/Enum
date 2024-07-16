using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Days of a week : \n{(int)Days.Monday} {Days.Monday}\n{(int)Days.Tuesday} {Days.Tuesday}\n"+
                $"{(int)Days.Wednesday} {Days.Wednesday}\n{(int)Days.Thursday} {Days.Thursday}\n"+
                $"{(int)Days.Friday} {Days.Friday}\n{(int)Days.Saturday} {Days.Saturday}\n{(int)Days.Sunday} {Days.Sunday}");
        }
    }
}
