﻿using System;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace CSharp_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTypes();
        }

        static void MyString()
        {
            Console.Write("What year were you born?");
            int yearBorn = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your age?");
            string myName = Console.ReadLine();

            Console.WriteLine($"Your age is: {myName}, and you were born in {yearBorn}");

            string myString1 = "This is my first String";
            string theTruth = "The last thing a ninja would do is admit to being a ninja.";
            string theLie = "I am not a ninja.";
            Console.WriteLine("This is my string. " + myString1);
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            Console.WriteLine($"Here are two truths and a lie. {theTruth}, {theLie}");
            
        }
        

        static void DataTypes()
        {
            int myAge = 99;
            string name = "Bob the builder";
            bool awesome = true;
            char grade = 'F';
            float altitude = 90.265141f;
            double bankBalance = -4000000;
            decimal pi = 3.14159265359m;

            ///output
            ///
            Console.WriteLine($"int = {myAge}.");
            Console.WriteLine($"string = {name}.");
            Console.WriteLine($"bool = {awesome}."); 
            Console.WriteLine($"char = {grade}.");
            Console.WriteLine($"float = {altitude}.");
            Console.WriteLine($"double = {bankBalance}.");
            Console.WriteLine($"decimal = {pi}.");
        }
    }
}
