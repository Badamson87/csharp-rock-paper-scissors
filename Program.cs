using System;

namespace hwapp
{
    class Program
    {  
        static void Main(string[] args)
        {
            bool playing = true;
            while(playing)
            {

     
            Console.WriteLine("rock paper scissors");
            string choice = Console.ReadLine();
            // if(choice != "rock" || choice != "paper" || choice != "scissors")
            // {
            //     Console.WriteLine("Please choose rock paper or scissors");
            //     return;
            // }
            Console.WriteLine($"You played {choice}");
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            string computer = "";
            if(randomNumber == 0)
            {
                computer = "rock";
            }
            else if(randomNumber == 1)
            {
                computer = "paper";
            }
            else if(randomNumber == 2)
            {
                computer = "scissors";
            }
            Console.WriteLine($"The computer played {computer}");
            string outcome = "";
            if(choice == "rock" & randomNumber == 0)
            {
                outcome = "Tie game";
            }
            else if(choice == "rock" & randomNumber == 1)
            {
                outcome = "You Lose";
            }
            else if(choice == "rock" & randomNumber == 2)
            {
                outcome = "You Win";
            }
             if(choice == "paper" & randomNumber == 0)
            {
                outcome = "You Win";
            }
            else if(choice == "paper" & randomNumber == 1)
            {
                outcome = "Tie Game";
            }
            else if(choice == "paper" & randomNumber == 2)
            {
                outcome = "You lose";
            }
             if(choice == "scissors" & randomNumber == 0)
            {
                outcome = "You lose";
            }
            else if(choice == "scissors" & randomNumber == 1)
            {
                outcome = "You win";
            }
            else if(choice == "scissors" & randomNumber == 2)
            {
                outcome = "Tie Game";
            }
            Console.WriteLine($"{outcome}");
            }
        }
    }
}
