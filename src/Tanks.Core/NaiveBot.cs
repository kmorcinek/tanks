using System;
using Tanks.Core.api;

namespace Tanks.Core
{
    //using Logger = org.slf4j.Logger;
    //using LoggerFactory = org.slf4j.LoggerFactory;

    public class NaiveBot
    {
        private const string Url = "http://10.12.202.144:9999/tournaments";
        private const string TournamentId = "/sandbox-5";
        private const string AccessToken = "JoyfulMistyRoseRailRaven";

        //private static readonly Logger log = LoggerFactory.getLogger(typeof(NaiveBot));
        private readonly Random _random = new Random();

        public static void Main(params string[] args)
        {
            new NaiveBot().Run();
        }

        public virtual void Run()
        {
            TanksClient client = new TanksClient(Url, TournamentId, AccessToken);

            while (true)
            {
                Console.WriteLine("Waiting for the next game...");
                var gameSetup = client.GetMyGameSetup();
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
            if (_random.NextDouble() > 0.5)
            {
                return Command.fire(_random.Next(90) - 45, _random.Next(100) + 30);
            }
            else
            {
                return Command.move(_random.NextDouble() > 0.5 ? -100 : 100);
            }
        }
    }

}