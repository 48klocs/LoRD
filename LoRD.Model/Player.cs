using System;

namespace LoRD.Model
{
	public class Player : CreatureBase
	{	
		public const int DEFAULT_DAILY_MONSTER_TURNS = 40;
		public const int DEFAULT_DAILY_PLAYER_TURNS = 5;

		public int PlayerId { get; set; }
		public int MonsterTurns { get; set; }
		public int PlayerTurns  { get; set; }
		public DateTime LastLogIn  { get; set; }

		public int DailyMonsterTurns { get; set; }
		public int DailyPlayerTurns { get; set; }

		public void UpdateTurns ()
		{
			if (LastLogIn.Date < DateTime.Today) {
				this.PlayerTurns = this.DailyPlayerTurns;
				this.MonsterTurns = this.DailyMonsterTurns;
			}
		}

		public void Attack (ICreature enemy)
		{
			var playerCombat = new PlayerCombat(this);
			playerCombat.Attack(enemy);
		}

		public Player ()
		{
			this.DailyMonsterTurns = DEFAULT_DAILY_MONSTER_TURNS;
			this.DailyPlayerTurns = DEFAULT_DAILY_PLAYER_TURNS;
		}
	}
}

