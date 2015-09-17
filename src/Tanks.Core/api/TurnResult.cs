using System.Collections.Generic;

namespace Tanks.Core.api
{

	public class TurnResult
	{
		public IList<Tank> tanks;
		public IList<Outcome> outcome;
		public bool last;
	}

}