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
            int power = 0;

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
            int healthRegen = 0;
            int playerHealth = 0;

            // Increase health by regen amount
            playerHealth = playerHealth + healthRegen;

           



            ///int currentArea = 1;

            // Get input from player
            string input = Console.ReadLine();
            charactherClass = input;

            bool validInputReceived = false;

            while(validInputReceived == false)
            {
                // Class selection menu
                Console.WriteLine("Pick a Class");
                Console.WriteLine("1. Wizard");
                Console.WriteLine("2. Thief");
                Console.WriteLine("3. Knight");
                Console.WriteLine("4. Gunslinger");
                input = Console.ReadLine();

                // Class RPG
                // If player selected the first option... 

                if (input == "1" || input == "Wizard")
                {
                    //... give the player the stats for a Wizard traits
                    charactherClass = "Wizard";
                    playerHealth = 150;
                    power = 18;
                    validInputReceived = true;
                }
                else if (input == "2" || input == "Thief")
                {
                    //... give the player the stats for a Thief traits
                    charactherClass = "Thief";
                    playerHealth = 155;
                    power = 16;
                    validInputReceived = true;
                }
                else if (input == "3" || input == "Knight")
                {
                    //... give the player the stats for a Knight traits
                    charactherClass = "Knight";
                    playerHealth = 165;
                    power = 20;
                    validInputReceived = true;
                }
                else if (input == "4" || input == "Gunslinger")
                {
                    //... give the player the stats for a Gunslinger traits
                    charactherClass = "Gunslinger";
                    playerHealth = 175;
                    power = 18;
                    validInputReceived = true;
                }
                // If neither are true...
                else
                {
                    // Display error message
                    Console.WriteLine("Invalid Input");
                }
                Console.ReadKey();
                 // small error press twice move onto next screen
            }
            Console.Clear();

            Console.WriteLine("Your Characther Stats\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Class: " + charactherClass);
            Console.WriteLine("Health: " + playerHealth);
            Console.WriteLine("Power:" + power);

            Console.ReadKey();
            Console.Clear();


            // Encounter 
            int numberOfAttempts = 4;
            Console.WriteLine("solve the riddle you have" + numberOfAttempts + "attempts ");
            for (int i = 0; i < numberOfAttempts; i++)
            {
                Console.Clear();
                Console.WriteLine("broken");
                int attemptRemaining = numberOfAttempts - i;
                Console.WriteLine("Attempts Remaining: " + attemptRemaining);
                input = Console.ReadLine();

                if (input == "egg")
                {
                    Console.WriteLine("Congrats! You're gained coins");
                    break;
                }

                Console.WriteLine("Incorrect! The enemy laughs at you! Show off middle finger then leave.");

               

            }

            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("You encounter imp!!" +
                "\n The imp slaying rabbit but you can defeat imp while he distracted." +
                "\n 1. Kill Imp 2. Flee");


            int numberOfWait = 2;
            for (int i = 0; i < numberOfWait; i++)
            {
                
                Console.WriteLine("If wait long enough imp ");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("You killed imp.");

                }
                else if (input == "2")
                {
                    Console.WriteLine("You fled away from combat.");
                }
            } 
            


            // Game Over
            bool gameOver = true;

            if (playerHealth < 0)
            {
                gameOver = playerHealth < 0;
                Console.WriteLine("You died");
            }
        }
    }
}
