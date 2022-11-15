using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    internal class Methods
    {
        // Method to provide random computer choice
        public static string ComputerChoice()
        {
            string[] choices = { "rock", "paper", "scissors" };
            Random rand = new Random();
            int index = rand.Next(choices.Length);
            return choices[index];
        }
    }
}
