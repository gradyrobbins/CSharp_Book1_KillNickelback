using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Kill Nickelback");
            Console.WriteLine("");
           // Define a list of dictionaries.
           // Each dictionary will have a key of type string, and a value of type string.
           // Assign the list to a goodSongs variable.
            List<Dictionary<string,string>> goodSongs= new List<Dictionary<string,string>>();

            // Define a HashSet, named allSongs, that contains 7 dictionaries. Each tuple should contain two string values:
            // The name of an artist
            // A song by that artist
            // // Example
            // HashSet<(string, string)> songs = new HashSet<(string, string)>();
                HashSet<(string artist, string song)> allSongs = new HashSet <(string,string)>();
            // Make sure that some of the songs are from the band Nickelback. You can see a list of their greatest hits on Amazon.
                allSongs.Add(("NickleBack","How You Remind Me"));
                allSongs.Add(("NickleBack","Rockstar"));
                allSongs.Add(("NickleBack","Savin' Me"));
                allSongs.Add(("Train","Drops of Jupiter"));
                allSongs.Add(("Radiohead","Creep"));
                allSongs.Add(("Rage Against the Machine","Killing in the Name"));
                allSongs.Add(("Rolling Stones","Paint it Black"));

            // Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".
                foreach (var item in allSongs)
                {
            // If the band is not Nickelback, then add it to the goodSongs list.
                    if(item.artist != "NickleBack"){
                        goodSongs.Add(item);
                    }

                }

            // Use another foreach loop to print out all the good songs.
            foreach (var item in goodSongs)
            {

            // Console.WriteLine("good songs"  + $" {item.song} by {item.artist}");
            }
        }




    }
}
