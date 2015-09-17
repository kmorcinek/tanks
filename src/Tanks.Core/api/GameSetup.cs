using System.Collections.Generic;
using System.Globalization;

namespace Tanks.Core.api
{

	public class GameSetup
	{
		public string name;
		public Scene scene;
		public IList<Player> players;
		public IList<Tank> tanks;

		public class Scene
		{
			public Landscape landscape;

			public override string ToString()
			{
				return "Scene [landscape=" + landscape + "]";
			}
		}

		public class Landscape
		{
			public IList<Vector2> points;

			public override string ToString()
			{
				return "Landscape [points=" + points + "]";
			}
		}

		public class Player
		{
			public string name;
			public string color;

			public override string ToString()
			{
				return "Player [name=" + name + ", color=" + color + "]";
			}

		}

        public class Tank
        {
            public string name;
            public string color;
            public Vector2 position;
        }

		public override string ToString()
		{
			return "GameSetup [name=" + name + ",\n scene=" + scene + ",\n players=" + players + "]";
		}
	}


}