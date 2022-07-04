using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stock Management \n" +
               "Enter 1 to Add new Stock\n" +
               "Enter 2 for the Total Value of Stock");
            int entered = int.Parse(Console.ReadLine());

            StockImplementation im = new StockImplementation();

            switch (entered)
            {
                case 1:
                    im.AddStock();
                    break;
                case 2:
                    im.ValueOfStacks();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
            
}






    

        
    

