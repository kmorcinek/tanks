using System;
using System.Threading.Tasks;
using Tanks.Core.api;

namespace Tanks.Core
{
    //using Logger = org.slf4j.Logger;
    //using LoggerFactory = org.slf4j.LoggerFactory;

    public class NaiveBot
    {
        public static Command CurrentCommand;

        //private static readonly Logger log = LoggerFactory.getLogger(typeof(NaiveBot));
        private Random rand = new Random();

        public static void Main(params string[] args)
        {
            new NaiveBot().run();
        }

        public virtual void run()
        {
            TanksClient client = new TanksClient("http://10.12.202.144:9999/tournaments", "/sandbox-5", "JoyfulMistyRoseRailRaven");

            while (true)
            {
                GameSetup gameSetup;
                Console.WriteLine("Waiting for the next game...");
                gameSetup = client.MyGameSetup();
                //Console.WriteLine(gameSetup);

                PlayGame(gameSetup, client);
            }
        }

        private void PlayGame(GameSetup gameSetup, TanksClient client)
        {
            bool gameFinished = false;
            while (!gameFinished)
            {
                //Console.WriteLine("next shot");
                TurnResult result = client.SubmitMove(GenerateCommand(gameSetup));

                gameFinished = result.last;
            }

            Console.WriteLine("game finished");
        }

        public virtual Command GenerateCommand(GameSetup gameSetup)
        {
            if (rand.NextDouble() > 0.5)
            {
                return Command.fire(rand.Next(90) - 45, rand.Next(100) + 30);
            }
            else
            {
                return Command.move(rand.NextDouble() > 0.5 ? -100 : 100);
            }
        }
    }

}