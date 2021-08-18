using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            string charactherClass;
            int power = 25;

            // Welcome Game Screen
            string welcome = ("Welcome to RPG");
            Console.WriteLine(welcome);


            // Player Input for given name
            string name = "Empty";
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();

            // Display: Hello "given name"
            Console.WriteLine("Hello " + name);
            Console.Read();


            // Given Name, + background info
            string backgroundInfo = " the Fool Arcana new beginnings, having faith in the future, " +
                "being inexperienced, not knowing what to expect, having beginner's luck, " +
                "improvisation and believing in the universe";

            Console.WriteLine(name + "," + backgroundInfo); 
            

            // Health exercise

            // Initialize default health
            int healthRegen = 50;
            int playerHealth = 100 / 2;

            // Increase health by regen amount
            playerHealth = playerHealth + healthRegen;
            playerHealth += healthRegen;

            //Display health to user
            Console.WriteLine(playerHealth);





            ///int currentArea = 1;



            // Get input from player
            string input = Console.ReadLine();
            charactherClass = input;

            // Job selection menu
            Console.WriteLine("Pick a Class");
            Console.WriteLine("1. Wizard");
            Console.WriteLine("2. Thief");
            Console.WriteLine("3. Knight");
            Console.WriteLine("4. Gunslinger"); 



            // Class RPG
            // If player selected the first option... 

            if (input == "1" || input == "Wizard")
            {
                //... give the player the stats for a Wizard traits
                charactherClass = "Wizard";
                playerHealth = 150;
                power = 18;
            }
            else if (input == "2" || input == "Thief")
            {
                //... give the player the stats for a Thief traits
                charactherClass = "Thief";
                playerHealth = 155;
                power = 16;
            }
            else if (input == "3" || input == "Knight")
            {
                //... give the player the stats for a Knight traits
                charactherClass = "Knight";
                playerHealth = 165;
                power = 20;
            }
            else if (input == "4" || input == "Gunslinger")
            {
                //... give the player the stats for a Gunslinger traits
                charactherClass = "Gunslinger";
                playerHealth = 175;
                power = 18;
            }

            // If neither are true...
            else
            {
                // display error message
                Console.WriteLine("Invalid Input");
            }


            Console.WriteLine("Your Characther Stats\n");
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Class" + charactherClass);
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Power:" + power);

            Console.ReadKey();
            Console.Clear();


            


            // Encounter 
            Console.WriteLine("You encounter imp!!" +
                "\n The imp slaying rabbit but you can defeat imp while he distracted" +
                "1. Kill Imp 2. Flee" );
            if (input == "1" ||input == "2") 
            { 


            }

            // Game Over
            bool gameOver = false;

            if (gameOver)
            {
                gameOver = playerHealth < 0;
            }
        }
    }
}
