using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            string firstname;
            string lastname;
            Console.WriteLine("Enter name");
            firstname = Console.ReadLine();
            Console.WriteLine("enter l name");
            lastname = Console.ReadLine();
            Console.WriteLine("welcome" + firstname + " " + lastname);

            Console.ReadKey();
        }
    }
}
