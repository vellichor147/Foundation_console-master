using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation_console
{
    static class Intro
    {
        

        static Intro ()
        {

        }
        
        public static void Introduction()
        {
            Console.Write("Enter your name: ");
            GameManagement.PlayerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello " + GameManagement.PlayerName + Environment.NewLine);
            Console.WriteLine("As the most advanced AI that ever existed you are tasked with the important assigment." +
                Environment.NewLine + "Mankind is on the verge of extincion. Last chance of survival is colonization of another planet. " +
                Environment.NewLine + "Since Solar system is out of the question, every last resource is being spent on building " +
                Environment.NewLine + "spaceship capable of travelling to other star systems. Since it will be a long journey people " +
                Environment.NewLine + "will travel in stasis. Your first task is to design the most optimal spaceship to ensure the highest " +
                Environment.NewLine + "probability of sucsseful colonization. Second task, taking controll of the ship and finding planet " +
                Environment.NewLine + "suitable for colonization." + Environment.NewLine);
            Console.Write("Press ENTER to continue...");
            GameManagement.PressEnter();

            Console.Write("We made a list of technologies and design approaches that we are able to develop and implement." +
               Environment.NewLine + "Resources are limited and time is short. Please advise on what should we spend are " +
               "last resources." + Environment.NewLine);
            Console.Write(Environment.NewLine + "Press ENTER to continue...");
            GameManagement.PressEnter();
        }
    }
}
