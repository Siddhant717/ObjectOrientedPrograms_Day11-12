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
               
            }
            Console.WriteLine("-----------------");
            for (int i = 0; i < data.TypesOfGrains.Count; i++)
            {
                Console.WriteLine(data.TypesOfGrains[i].Name);
                Console.WriteLine(data.TypesOfGrains[i].Weight);
                Console.WriteLine(data.TypesOfGrains[i].Price);
                
            }

            Console.WriteLine("-----------------");
            for (int i = 0; i < data.TypesOfWheats.Count; i++)
            {
                Console.WriteLine(data.TypesOfWheats[i].Name);
                Console.WriteLine(data.TypesOfWheats[i].Weight);
                Console.WriteLine(data.TypesOfWheats[i].Price);
                
            }

            Console.ReadLine();
        }
    }






    

        
    
}
