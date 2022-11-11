using System;

namespace ca1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start the game by printing a welcome message to the console and asking the player for their name.
            Console.WriteLine("Welcome to the game!");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            // Initialize variables for the player's name, health, and number of enemies defeated.
            int health = 100;
            int enemiesDefeated = 0;

            // Create a while loop that runs as long as the player's health is greater than 0.
            while (health > 0)
            {
                // Within the loop, print out the player's current stats and give them a list of possible actions to take.
                Console.WriteLine($"\nName: {name}\nHealth: {health}\nEnemies Defeated: {enemiesDefeated}");
                Console.WriteLine("\nWhat would you like to do?\n1. Attack\n2. Heal\n3. Run Away");

                // Use a switch statement to handle the player's input and carry out the appropriate action.
                int damageAmount = 0;
                int healAmount = 0;
                switch (Console.ReadLine())
                {
                    case "1":
                        // If the player chooses to attack, reduce an enemy's health by a random amount between 5 and 20.
                        damageAmount = new Random().Next(5, 20);
                        Console.WriteLine($"You attacked by enemy. {damageAmount} damage!");
                        health -= damageAmount;
                        if (health <= 0) { break; }

                        damageAmount = new Random().Next(5, 20);
                        Console.WriteLine($"You attacked an enemy and did {damageAmount} damage!");
                        break;
                    case "2":
                        // If the player chooses to heal, increase their health by a random amount between 10 and 25.
                        damageAmount = new Random().Next(1, 50);
                        Console.WriteLine($"You attacked by enemy. {damageAmount} damage!");
                        health -= damageAmount;
                        if (health <= 0) { break; }

                        healAmount = new Random().Next(1, 50);
                        health += healAmount;
                        if (health > 100) { health = 100; }
                        Console.WriteLine($"You healed yourself and gained {healAmount} health!");
                        damageAmount = 0;
                        break;
                    case "3":
                        // If the player chooses to run away, end the game.
                        Console.WriteLine("You have chosen to run away.");
                        return;
                    default:
                        // If the player enters something other than A, B, or C, print out an error message.
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                // If the player defeats an enemy, increase their defeating score by 1.
                if (damageAmount > 0)
                {
                    enemiesDefeated++;
                }

                // When the player's health reaches 0, the while loop will exit and print out a game over message along with the player's final stats.
                if (health <= 0)
                {
                    Console.WriteLine($"\nGAME OVER\nFinal Score:\nName: {name}\nEnemies Defeated: {enemiesDefeated}");
                }
            }
        }
    }
}
