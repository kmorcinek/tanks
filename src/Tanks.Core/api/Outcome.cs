namespace Tanks.Core.api
{
	public class Outcome
	{
		public string name;
		public HitType type;
		public Vector2 hitCoordinates;
		public Tank target;
		public bool targetDestroyed;

		public enum HitType
		{
			miss,
			tank_hit,
			ground_hit
		}
	}

}