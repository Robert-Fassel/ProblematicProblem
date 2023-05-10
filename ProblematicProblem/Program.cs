using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {

        
        static bool cont = true;
        static List<string> activities = new List<string>() { "Movies",
            "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", 
            "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
{
            
            Random rng = new Random();
            
            
            while (true) {
                Console.WriteLine();
                Console.Write("Hello, welcome to the random activity generator!" +
                    " \nWould you like to generate a random activity? [y/n]: ");
                Console.WriteLine();
            
                var response = Console.ReadKey();
                if (response.KeyChar == 'y')
                {
                    cont = true;
                    break;
                }
                if (response.KeyChar == 'n')
                {
                    cont = false;
                    break;
                }
                else continue;
            }
               
           
    Console.WriteLine();
    Console.Write("We are going to need your information first! What is your name? ");
    string userName = Console.ReadLine();
    Console.WriteLine();
    Console.Write("What is your age? ");
    int userAge = int.Parse(Console.ReadLine());
    Console.WriteLine();
            bool seeList;
            while (true)
            {
                Console.WriteLine();
                Console.Write("Would you like to see the current list of" +
                    " activities? [y/n]: ");
                Console.WriteLine();
                var response = Console.ReadKey();
                if (response.KeyChar == 'y')
                {
                     seeList = true;
                    break;
                }
                if (response.KeyChar == 'n')
                {
                    seeList = false;
                    break;
                }
                else continue;

               
            }
    if (seeList)
    {
        foreach (string activity in activities)
        {
                    Console.WriteLine();
            Console.Write($"{activity} ");
            Thread.Sleep(250);
        }
        Console.WriteLine();
                bool addToList;
                while (true) {
                    Console.WriteLine();
                    Console.Write("Would you like to add any activities before we generate one?" +
                        " [y/n]: ");
                    Console.WriteLine();
                    var response = Console.ReadKey();
                    if (response.KeyChar == 'y')
                    {
                      addToList = true;
                        break;
                    }
                    if (response.KeyChar == 'n')
                    {
                        addToList = false;
                        break;
                    }
                    else continue;
                }
        Console.WriteLine();
        while (addToList)
        {
            Console.Write("What would you like to add? ");
            string userAddition = Console.ReadLine();
            activities.Add(userAddition);
            foreach (string activity in activities)
            {
                Console.Write($"{activity} ");
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.WriteLine("Would you like to add more? [y/n]: ");
                    Console.WriteLine();
                    var response = Console.ReadKey();
                    if (response.KeyChar == 'y')
                    {
                        continue;
                    }
                    if (response.KeyChar == 'n')
                    {
                        break;
                    }
                    else continue;
        }
    }

            while (cont)
            {
                ConsoleKeyInfo response;
                Console.WriteLine();
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                Console.Write("Choosing your random activity");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber];

                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");
                    activities.Remove(randomActivity);
                    randomNumber = rng.Next(activities.Count);
                    randomActivity = activities[randomNumber];
                }
                while (true)
                {
                    Console.WriteLine();
                    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! " +
                        $"Is this ok or do you want to grab another activity? Keep[y]/Redo[n]: ");
                    Console.WriteLine();
                    response = Console.ReadKey();
                    if (response.KeyChar == 'y' || response.KeyChar == 'n')
                    {
                        break;
                    }
                    else continue;
                }
                
                    if (response.KeyChar == 'y')
                {
                    Console.WriteLine();
                    Console.WriteLine($"Enjoy!");
                    break;
                }
                if (response.KeyChar == 'n')
                {
                    continue;
                }
                
         cont = bool.Parse(Console.ReadLine());
    }
}
    }
}