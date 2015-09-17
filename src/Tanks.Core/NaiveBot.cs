using System;
using Tanks.Core.api;

namespace Tanks.Core
{
    //using Logger = org.slf4j.Logger;
    //using LoggerFactory = org.slf4j.LoggerFactory;

    public class NaiveBot
	{
        //private static readonly Logger log = LoggerFactory.getLogger(typeof(NaiveBot));
		private Random rand = new Random();

		public static void Main(params string[] args)
		{
			(new NaiveBot()).run();
		}


	    public static void Register()
	    {
	        
	    }

		public virtual void run()
		{
            TanksClient client = new TanksClient("http://localhost:9999", "master", "JoyfulMistyRoseRailRaven");

			while (true)
			{
                //log.info("Waiting for the next game...");
				GameSetup gameSetup = client.MyGameSetup;
                //log.info("Playing {}", gameSetup);

				playGame(gameSetup, client);
			}
		}

		private void playGame(GameSetup gameSetup, TanksClient client)
		{
			bool gameFinished = false;
			while (!gameFinished)
			{
				TurnResult result = client.submitMove(generateCommand());

				gameFinished = result.last;
			}
		}

		public virtual Command generateCommand()
		{
			if (rand.NextDouble() > 0.2)
			{
				return Command.fire(rand.Next(90) - 45, rand.Next(100) + 30);
			}
			else
			{
				return Command.move(rand.NextDouble() > 0.5 ? - 100 : 100);
			}
		}
	}

}