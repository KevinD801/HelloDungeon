using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            // Welcome Game Screen
            string welcome = ("Welcome to RPG");
            Console.WriteLine(welcome);


            // Player Input for given name
            string name = "Empty";
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();

            // Display: Hello "username"
            Console.WriteLine("Hello " + name);
            Console.Read();


            // Given Name, + background info
            string charactherName = " the Fool Arcana new beginnings, having faith in the future, " +
                "being inexperienced, not knowing what to expect, having beginner's luck, " +
                "improvisation and believing in the universe";
            
            Console.WriteLine(name + "," + charactherName);
            


            int currentArea = 1;
            


            // Class RPG
            string charactherClass = "Thief";
            Console.WriteLine("Your class is " + charactherClass);




            // Health
            // Initialize default health
            int healthRegen = 50;
            int health = 100;
            health += healthRegen;

            // Display health to user
            Console.WriteLine("HP: " + health);

            // Attack Power
            float power = 15.0f;
            Console.WriteLine("ATK Power: " + power);

            

            // Game Over
            bool gameOver = false;
        }
    }
}
