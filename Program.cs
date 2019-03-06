using System;
using System.Collections.Generic;
namespace listplanetsdictonarty {
    class Program {
        static void Main (string[] args) {
            List<string> planetList = new List<string> () { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Neptune", "Uranus", "Pluto" };
            PrintList(planetList);

                        List<string> Probes1 = new List<string> () { "Opritunity" };
            PrintList(Probes1);
       Dictionary<string, string> Merger = new Dictionary<string, string> (){};


       foreach (var planet in planetList)
       foreach(var Pro in Probes1)
       {Merger.Add(planet, Pro);}


        List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>(){};
        for (int i = 0; i < planetList.Count - 1; i++)
        {
       if( i == 3 ){
Console.WriteLine("Opritunity went to " + planetList[i]);
        }
else {
    Console.WriteLine("Opritunity did not go to " + planetList[i]);

}
        }
        }
        static void PrintDictonary (Dictionary<string, string> dict) {
        foreach (KeyValuePair<string, string> kvp in dict) {
            Console.WriteLine ($"key:) {kvp.Key}, Value: {kvp.Value}");
        }}

        static void PrintList(List<string> Lists) {
        foreach (var List  in Lists) {
            // Console.WriteLine(List);
    }

        }
    }
}