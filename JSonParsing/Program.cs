using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JSonParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            var humans = File.Exists("people.json") ? JsonConvert.DeserializeObject<List<HumanModel>>(File.ReadAllText("people.json")) : throw new Exception();

            foreach (var item in humans)
            {
                Console.WriteLine(item.name);
            }
            Console.ReadKey();
        }
    }
}
