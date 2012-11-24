using System;

namespace LoRD.Model
{
	public abstract class CreatureBase : ICreature
	{
		public string Name { get; set; }
		public int Level { get; set; }
		public int Strength { get; set; }
		public int HitPoints { get; set; }
		public int Gold { get; set; }
		public int Luck { get; set; }
		
		public bool IsAlive 
		{
			get
			{
				return this.HitPoints > 0;
			}
		}
	}
}

