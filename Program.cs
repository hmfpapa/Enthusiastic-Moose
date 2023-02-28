using System;
using System.Collections.Generic;
using System.Linq;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {



            void MooseSays(string message)
            {
                Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
            }


            bool MooseAsks(string question)
            {
                Console.Write($"{question} (Y/N): ");
                string answer = Console.ReadLine().ToLower();

                while (answer != "y" && answer != "n")
                {
                    Console.Write($"{question} (Y/N): ");
                    answer = Console.ReadLine().ToLower();
                }

                if (answer == "y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };


            void Main()
            {
                Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();

                // Let the moose speak!
                MooseSays("H I, I'M  E N T H U S I A S T I C !");
                MooseSays("I really am enthusiastic");


            }
            Main();
            Question("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
            Question("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");

            void Question(string question, string Y, string N)
            {
                bool answer = MooseAsks(question);
                if (answer)
                {
                    MooseSays(Y);
                }
                else
                {
                    MooseSays(N);
                }
            }
            Response("As I see it, yes", 0);
            Response("Ask again later", 1);
            Response("Better not tell you now.", 2);
            Response("Cannot predict now.", 3);
            Response("Concentrate and ask again.", 4);
            Response("Don’t count on it.", 5);
            Response("It is certain.", 6);
            Response("It is decidedly so.", 7);
            Response("Most likely.", 8);
            Response("My reply is no.", 9);
            Response("My sources say no.", 10);
            Response("Outlook not so good", 11);
            Response("Outlook good.", 12);
            Response("Reply hazy, try again.", 13);
            Response("Signs point to yes.", 14);
            Response("Very doubtful.", 15);
            Response("Without a doubt.", 16);
            Response("Yes.", 17);
            Response("Yes – definitely.", 18);
            Response("You may rely on it.", 19);



            void Response(string response, int Id)

            Moose
            {
                Random r = new Random();
                int genRand = r.Next(0, 19);
                question = Console.ReadLine()
                while (Question !== "")
                {
                MooseSays(response);
                }
            }

        }

    }
}


