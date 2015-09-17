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

            Task.Factory.StartNew(() =>
                (new NaiveBot()).run());

            CurrentCommand = new Command
            {
                shotAngle = 50,
                shotPower = 60,
            };

            while (true)
            {
                var readLine = Console.ReadLine();

                // 1,1
                var strings = readLine.Split(',');

                CurrentCommand = new Command
                {
                    shotAngle = int.Parse(strings[0]),
                    shotPower = int.Parse(strings[1])
                };
            }
        }

        public virtual void run()
        {
            TanksClient client = new TanksClient("http://10.12.202.144:9999/tournaments", "/sandbox-5", "JoyfulMistyRoseRailRaven");

            while (true)
            {
                GameSetup gameSetup;
                try
                {
                    Console.WriteLine("setup before");
                    //log.info("Waiting for the next game...");
                    gameSetup = client.MyGameSetup();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                Console.WriteLine("setup ok");
                //log.info("Playing {}", gameSetup);

                PlayGame(gameSetup, client);
                Console.WriteLine("next game started");
            }
        }

        private void PlayGame(GameSetup gameSetup, TanksClient client)
        {
            bool gameFinished = false;
            while (!gameFinished)
            {
                //Console.WriteLine("next shot");
                TurnResult result = client.submitMove(GenerateCommand(gameSetup));

                gameFinished = result.last;
            }

            Console.WriteLine("game finished");
        }

        public virtual Command GenerateCommand(GameSetup gameSetup)
        {
            return NaiveBot.CurrentCommand;

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