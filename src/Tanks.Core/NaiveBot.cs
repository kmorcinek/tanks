using System;

namespace com.getbase.hackkrk.tanks
{

    //using Logger = org.slf4j.Logger;
    //using LoggerFactory = org.slf4j.LoggerFactory;

	using Command = com.getbase.hackkrk.tanks.api.Command;
	using GameSetup = com.getbase.hackkrk.tanks.api.GameSetup;
	using TanksClient = com.getbase.hackkrk.tanks.api.TanksClient;
	using TurnResult = com.getbase.hackkrk.tanks.api.TurnResult;

    //public static class Program
    //{
    //    public static void Mian()
    //    {
    //        NaiveBot.Main();
    //    }
    //}

    public class NaiveBot
	{
        //private static readonly Logger log = LoggerFactory.getLogger(typeof(NaiveBot));
		private Random rand = new Random();

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static void main(String... args) throws Exception
		public static void Main(params string[] args)
		{
			(new NaiveBot()).run();
		}


	    public static void Register()
	    {
	        
	    }
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void run() throws Exception
		public virtual void run()
		{
            TanksClient client = new TanksClient("http://localhost:9999", "master", "JoyfulMistyRoseRailRaven");

			while (true)
			{
                //log.info("Waiting for the next game...");
				GameSetup gameSetup = client.MyGameSetup;
                //log.info("Playing {}", gameSetup);

				playGame(client);
			}
		}

		private void playGame(TanksClient client)
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