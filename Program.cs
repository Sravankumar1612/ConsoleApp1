﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int empId;
            string empName;
            string empGender;
            double empSal;
            DateTime doj;


            Console.WriteLine("Employee ID");
            empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Employee Name");
            empName = Console.ReadLine();
            Console.WriteLine("Employee Gender");
            empGender = Console.ReadLine();
            Console.WriteLine("Employee Salary");
            empSal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining");
            doj = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("ID\t" + "Employee Name\t" + "Employee Gender\t" +
                "Employee Salary\t" + "Date of Joining");
            Console.WriteLine(empId + "\t" + empName + "\t" + empGender + "\t" + empSal + "\t" + doj);
            
            if (empSal > 90000)
            {
                Console.WriteLine("You have to pay 30%tax");
            }
            else
            {
                Console.WriteLine("You have to pay 15% tax");
            }
            Console.ReadKey();
        }
    }
}
