using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_project
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockNumberGenerator generator = new BlockNumberGenerator();

            Console.WriteLine(generator.GetNumber(9));



        //    Console.WriteLine("Welcome!");
        //    string[] options = { "rock", "paper", "scissors" };

        //    Console.WriteLine("Make a guess (1 for rock, 2 for paper, 3 for scissors)");
        //    int choice = int.Parse(Console.ReadLine());
        //    string weapon = options[choice - 1];

        //    Random rnd = new Random();
        //    int computerChoice = rnd.Next(3);
        //    string computerWeapon = options[computerChoice];

        //    Console.WriteLine();
        //    Console.WriteLine(3);
        //    System.Threading.Thread.Sleep(5000); // 5,000 ms


        //    Console.WriteLine(2);
        //    System.Threading.Thread.Sleep(5000); // 5,000 ms

        //    Console.WriteLine(1);
        //    System.Threading.Thread.Sleep(5000); // 5,000 ms

        //    Console.WriteLine($"You picked {weapon}");
        //    Console.WriteLine($"Computer picked {computerWeapon}");

        //    if (weapon == "paper" && computerWeapon == "rock")
        //    {
        //        Console.WriteLine("You win! Paper Covers Rock");
        //    }
        //    else if (weapon == "scissors" && computerWeapon == "paper")
        //    {
        //        Console.WriteLine("You win! Scissors cuts paper");
        //    }
            




        }
    }
}
