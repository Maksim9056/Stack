﻿namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int > list = new List<int>() { 1,2,3,4,5,6,7,8,9};
            Stack<int> stack = new Stack<int>(list);

            var value  = stack.Max();

            var i = value.ToString(); ;
            Console.WriteLine(i);
            
            Console.ReadLine();
        }
    }
}