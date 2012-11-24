using System;

namespace LoRD.Model
{
	public interface IPlayer : ICreature
	{
		int PlayerId { get; set; }

		int MonsterTurns { get; set; }
		int PlayerTurns { get; set; }

		int DailyMonsterTurns { get; set; }
		int DailyPlayerTurns { get; set; }

		DateTime LastLogIn { get; set; }

		void UpdateTurns();

		void Attack(ICreature enemy);
	}
}

