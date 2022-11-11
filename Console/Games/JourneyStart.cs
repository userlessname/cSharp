using System;
using System.Collections.Generic;

namespace ca1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Implement Functionality Here

            Console.WriteLine("Welcome to my game!");

            //Get player name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            //Create player object
            Player player = new Player(name);

            //Player character creation
            player.ChooseClass();

            //Generate starting stats for player
            player.RollStats();

            //Print player stats
            player.PrintStats();

            //Lore

            Console.WriteLine("The year is 1565, and you find yourself in the land of bohemia.");

            Console.WriteLine("You have no idea how you got here.");

            Console.WriteLine("All you know is that there's a war going on, and you're on the wrong side of it.");

            Console.WriteLine("The good news is that you're not alone.");

            Console.WriteLine("You see a group of people in the distance, and they seem to be friendly.");

            Console.WriteLine("You approach them to ask for help.");

            //Tutorial

            Console.WriteLine("They seem to be lost as well.");

            Console.WriteLine("The group leader, who introduces himself as Radim, asks if you know how to fight.");

            Console.WriteLine("Not knowing what else to do, you say yes.");

            Console.WriteLine("Radim seems pleased to hear this.");

            Console.WriteLine("He tells you that he and his group are part of a rebel army fighting against the king's forces.");

            Console.WriteLine("The king's men have been rounding up people and forcing them into servitude.");

            Console.WriteLine("Radim and his group have been fighting back, but they need all the help they can get.");

            Console.WriteLine("He asks if you're willing to join their cause.");

            Console.WriteLine("What do you say?");

            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("Great! We could use someone with your skills.");

                Console.WriteLine("Let me introduce you to the rest of the group.");

                //Add party members to player's party

                player.party.Add(new PartyMember("Rose", "Rogue"));
                player.party.Add(new PartyMember("Thorn", "Warrior"));
                player.party.Add(new PartyMember("Falk", "Mage"));

                foreach (PartyMember p in player.party)
                {
                    Console.WriteLine("This is " + p.name + ". They're our " + p.classType + ".");
                }

                Console.WriteLine("We'll teach you the ropes as we go along.");

                Console.WriteLine("For now, let's just focus on getting out of here alive.");
            }
            else
            {
                Console.WriteLine("That's too bad.");

                Console.WriteLine("We could really use your help.");

                Console.WriteLine("But I understand if you don't want to get involved.");

                Console.WriteLine("Good luck getting out of here alive.");
            }
        }
    }

    public class Player
    {
        public string name;
        public string classType;
        public int health;
        public int damage;
        public int armor;

        public List<PartyMember> party = new List<PartyMember>();

        public Player(string name)
        {
            this.name = name;
        }

        public void ChooseClass()
        {
            //Allow player to choose their class

            Console.WriteLine("So, what class would you like to play as?");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Rogue");
            Console.WriteLine("3. Mage");

            string input = Console.ReadLine();

            if (input == "1")
            {
                this.classType = "Warrior";
                this.health = 100;
                this.damage = 20;
                this.armor = 10;
            }
            else if (input == "2")
            {
                this.classType = "Rogue";
                this.health = 80;
                this.damage = 30;
                this.armor = 5;
            }
            else if (input == "3")
            {
                this.classType = "Mage";
                this.health = 60;
                this.damage = 40;
                this.armor = 0;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                ChooseClass();
            }
        }

        public void RollStats()
        {
            //Randomly generate player stats

            Random rand = new Random();

            this.health += rand.Next(1, 21);
            this.damage += rand.Next(1, 11);
            this.armor += rand.Next(1, 6);
        }

        public void PrintStats()
        {
            //Print player stats

            Console.WriteLine();
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Class: " + this.classType);
            Console.WriteLine("Health: " + this.health);
            Console.WriteLine("Damage: " + this.damage);
            Console.WriteLine("Armor: " + this.armor);
            Console.WriteLine();
        }
    }

    public class PartyMember
    {
        public string name;
        public string classType;
        public int health;
        public int damage;
        public int armor;

        public PartyMember(string name, string classType)
        {
            this.name = name;
            this.classType = classType;
        }
    }
}
