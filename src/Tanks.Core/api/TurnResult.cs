using System.Collections.Generic;

namespace com.getbase.hackkrk.tanks.api
{

	public class TurnResult
	{
		public IList<Tank> tanks;
		public IList<Outcome> outcome;
		public bool last;
	}

}