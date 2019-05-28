/* 
    Author: Chris Morgan
    Date: 05/28/2019
    Exercises: 
        1. Planets + Spaceships
        2. Random Numbers
*/

using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Begin Planet and Spaceships exercise
            Console.WriteLine("Begin Planets and Spaceship Exercise: ");
            // Create List of strings called 'planetList' which contains 'Mercury' and 'Mars'

            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            // 1. Add 'Jupiter' and 'Saturn' at the end of the list:

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // 2. Create another list with "Neptune" and "Pluto"
            List<string> lastTwoPlanets = new List<string>(){
                "Uranus", "Neptune"
            };

            // 3. Use AddRange() to combine planetList and lastTwoPlanets List. Write the resulting list to the console to make sure this worked properly.
            Console.WriteLine(" ");
            Console.WriteLine("Before combining with AddRange():");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            planetList.AddRange(lastTwoPlanets);
            Console.WriteLine(" ");
            Console.WriteLine("After combining list containing Uranus and Neptune: ");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            // 4. Use Insert() to add Earth and Venus in the correct order

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            // 5. Use Add() again to add Pluto to the end of the list

            planetList.Add("Pluto");

            Console.WriteLine(" ");
            Console.WriteLine("After adding Venus and Earth to the correct spot. Then adding Pluto to the end.");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            // 6. Filtering out the rocky planets which are Mercury, Venus, Earth, and Mars. Use GetRange() to extract these rocky planets into a new list called rockyPlanets. The rocky planets will also remain in the original planetList.

            Console.WriteLine(" ");
            Console.WriteLine("Rocky Planets: ");
            List<string> rockyPlanets = planetList.GetRange(0, 4);
            foreach (string planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }

            planetList.Remove("Pluto");
            Console.WriteLine(" ");
            Console.WriteLine("After removing Pluto: ");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            // END PLANET AND SPACESHIP EXERCISE and BEGIN RANDOM NUMBERS EXERCISE
            Console.WriteLine(" ");
            Console.WriteLine("Begin Random Numbers Exercise: ");
            Console.WriteLine(" ");
            
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            for (int i=0; i<numbers.Count; i++) {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

                if(numbers.Contains(i)){
                    Console.WriteLine($"Number List contains {i}.");
                } else {
                    Console.WriteLine($"Number List does not contain {i}.");
                }
   
            }

        }
    }
}
