using System;
using NUnit.Framework;

namespace LoRD.Model.Test
{
	public class CreatureBaseTest
	{
	}

	[TestFixture]
	public class IsAliveTest : CreatureBaseTest
	{
		[Test]
		public void ByDefaultMonsterIsDead ()
		{
			var monster = new Monster();
			Assert.IsFalse(monster.IsAlive);
		}

		[Test]
		public void LessThanZeroHitPointsIsDead ()
		{
			var monster = new Monster
			{
				HitPoints = -1
			};

			Assert.IsFalse(monster.IsAlive);
		}

		[Test]
		public void OneHitPointIsAlive ()
		{
			var monster = new Monster
			{
				HitPoints = 1
			};
			
			Assert.IsTrue(monster.IsAlive);
		}
	}
}

