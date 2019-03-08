using System;
using System.Collections.Generic;
namespace listplanetsdictonarty {
    class Program {
        static void Main (string[] args) {
            List<string> planetList = new List<string> () { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Neptune", "Uranus", "Pluto" };
            List<Dictionary<string, string>> probes =
                new List<Dictionary<string, string>> () {
                    new Dictionary<string, string> { { "Viking", "Mars" } },
                    new Dictionary<string, string> { { "Opportunity", "Mars" } },
                    new Dictionary<string, string> { { "Curiosity", "Mars" } },
                    new Dictionary<string, string> { { "Mariner", "Venus" } },
                    new Dictionary<string, string> { { "Venera", "Venus" } },
                };
            foreach (string planets in planetList) // iterate planets
            {
                List<string> matchingProbes = new List<string> ();

                foreach (Dictionary<string, string> probe in probes) // iterate probes
                {
                    foreach (KeyValuePair<string, string> ITSGETINGDARK in probe) {

                        string planet = ITSGETINGDARK.Value;
                        string probeName = ITSGETINGDARK.Key;

                        if ((!matchingProbes.Contains (probeName)) && planets == planet) {
                            matchingProbes.Add (probeName);
                        }

                    }
                }

                string probeList = String.Join (", ", matchingProbes);
                Console.WriteLine ($"{planets}: {probeList}");

            }
        }
    }
}