using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ObjectOrientedPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Day11&12 Assignment-2\ObjectOrientedPrograms\ObjectOrientedPrograms\Inventory.json";

            FetchData fetchData = new FetchData();
            Inventory data = fetchData.Read(path);

            for (int i = 0; i < data.TypesOfRice.Count; i++)
            {
                Console.WriteLine(data.TypesOfRice[i].Name);
                Console.WriteLine(data.TypesOfRice[i].Weight);
                Console.WriteLine(data.TypesOfRice[i].Price);
                int value = data.TypesOfRice[i].Weight * data.TypesOfRice[i].Price;
                Console.WriteLine("The value of " + data.TypesOfRice[i].Name + " is :" + value);
                Console.WriteLine();


            }
            Console.WriteLine("-----------------");
            for (int i = 0; i < data.TypesOfGrains.Count; i++)
            {
                Console.WriteLine(data.TypesOfGrains[i].Name);
                Console.WriteLine(data.TypesOfGrains[i].Weight);
                Console.WriteLine(data.TypesOfGrains[i].Price);
                int value = data.TypesOfGrains[i].Weight * data.TypesOfGrains[i].Price;
                Console.WriteLine("The value of " + data.TypesOfGrains[i].Name + " is :" + value);
                Console.WriteLine();

            }

            Console.WriteLine("-----------------");
            for (int i = 0; i < data.TypesOfWheats.Count; i++)
            {
                Console.WriteLine(data.TypesOfWheats[i].Name);
                Console.WriteLine(data.TypesOfWheats[i].Weight);
                Console.WriteLine(data.TypesOfWheats[i].Price);
                int value = data.TypesOfWheats[i].Weight * data.TypesOfWheats[i].Price;
                Console.WriteLine("The value of " + data.TypesOfWheats[i].Name + " is :" + value);
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }






    

        
    
}
