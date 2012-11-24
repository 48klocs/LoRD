using System;

namespace LoRD.Model
{
	public interface ICreature
	{
		string Name { get; set; }

		int Level { get; set; }

		int Strength { get; set; }
		int HitPoints { get; set; }
		int Luck { get; set; }

		int Gold { get; set; }

		bool IsAlive { get; }
	}
}

