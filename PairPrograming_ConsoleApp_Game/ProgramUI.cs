﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PairPrograming_ConsoleApp_Game
{
    public class ProgramUI
    {
        Score myAnswer = new Score();
        public void Run()
        {
            RunMenu();
        }

        private void RunMenu()
        {
            bool keepThinking = true;
            do 
            {
                if (myAnswer.GameScore <= -10)
                {
                    Console.Clear();
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("Press any key to exit..............");
                    keepThinking = false;
                }
                if (myAnswer.GameScore >= 50)
                {
                    Console.Clear();
                    Console.WriteLine("You Win!");
                    Console.WriteLine("Press any key to exit..............");
                    keepThinking = false;
                }
                myAnswer.PrintScore();
                Console.WriteLine("Welcome to Random Trivia \n");
                Console.WriteLine("Enter the number of the Question you want to answer: \n" +
                    "1: Question1 \n" +
                    "2: Question2 \n" +
                    "3: Question3 \n" +
                    "4: Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Which element, previously used in the production of felt, lead to the expression 'mad as a hatter'? \n");
                        Console.WriteLine("Write you'r answer bellow and pres enter.............");
                        string response1 = Console.ReadLine();
                        //string answer = myAnswer.GetAnswer1();
                        string answer1 = "Mercury";
                        if (response1.ToLower() == answer1.ToLower())
                        {
                            Console.WriteLine("correct");
                            myAnswer.CorrectAnswer();
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("incorrect");
                            myAnswer.IncorrectAnswer();
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("In Canada, what is the national governing body for golf? \n");
                        Console.WriteLine("Write you'r answer bellow and pres enter.............");
                        string response2 = Console.ReadLine();
                        //string answer = myAnswer.GetAnswer1();
                        string answer2 = "Golf Canada";
                        if (response2.ToLower() == answer2.ToLower())
                        {
                            Console.WriteLine("correct");
                            myAnswer.CorrectAnswer();
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("incorrect");
                            myAnswer.IncorrectAnswer();
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("What is the name of the final course in all 'Mario Kart' videogames? \n");
                        Console.WriteLine("Write you'r answer bellow and pres enter.............");
                        string response3 = Console.ReadLine();
                        //string answer = myAnswer.GetAnswer1();
                        string answer3 = "Rainbow Road";
                        if (response3.ToLower() == answer3.ToLower())
                        {
                            Console.WriteLine("correct");
                            myAnswer.CorrectAnswer();
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("incorrect");
                            myAnswer.IncorrectAnswer();
                            Console.ReadKey();
                        }
                        Console.Clear();
                        break;
                    case "4":
                        keepThinking = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid");
                        break;
                }
            } while (keepThinking);

           
        }
    }
}