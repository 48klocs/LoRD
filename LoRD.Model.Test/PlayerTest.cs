using System;
using NUnit.Framework;

namespace LoRD.Model.Test
{
	[TestFixture]
	public class PlayerTest
	{
		[Test]
		public void WeDefaultMonsterTurns ()
		{
			var player = new Player();

			Assert.AreEqual(Player.DEFAULT_DAILY_MONSTER_TURNS,
			                player.DailyMonsterTurns);
		}

		[Test]
		public void WeDefaultPlayerTurns ()
		{
			var player = new Player();
			
			Assert.AreEqual(Player.DEFAULT_DAILY_PLAYER_TURNS,
			                player.DailyPlayerTurns);
		}
	}

	[TestFixture]
	public class UpdateTurnsTest : PlayerTest
	{
		[Test]
		public void ByDefaultAddsNoPlayerTurns ()
		{
			var player = new Player
			{
				LastLogIn = DateTime.Today
			};

			player.UpdateTurns();

			Assert.AreEqual(0,
			                player.PlayerTurns);
		}

		[Test]
		public void ByDefaultAddsNoMonsterTurns ()
		{
			var player = new Player
			{
				LastLogIn = DateTime.Today
			};
			
			player.UpdateTurns();
			
			Assert.AreEqual(0,
			                player.MonsterTurns);
		}

		[Test]
		public void AddsDefaultMonsterTurns ()
		{
			var player = new Player
			{
				LastLogIn = DateTime.Today.AddSeconds(-1)
			};
			
			player.UpdateTurns();
			
			Assert.AreEqual(Player.DEFAULT_DAILY_MONSTER_TURNS,
			                   player.MonsterTurns);
		}

		[Test]
		public void AddsDefaultPlayerTurns ()
		{
			var player = new Player
			{
				LastLogIn = DateTime.Today.AddSeconds(-1)
			};
			
			player.UpdateTurns();
			
			Assert.AreEqual(Player.DEFAULT_DAILY_PLAYER_TURNS,
			                player.PlayerTurns);
		}
	}
}

