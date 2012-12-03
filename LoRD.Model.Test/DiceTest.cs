using System;
using NUnit.Framework;

namespace LoRD.Model.Test
{
	public class DiceTest
	{
	}

	[TestFixture]
	public class NormalizeMinTest : DiceTest
	{
	}

	[TestFixture]
	public class RollTest : DiceTest
	{
		[Test]
		public void RollWorks ()
		{
			var dice = new Dice();
			Assert.DoesNotThrow(() => dice.Roll());
		}

		[Test]
		public void RollReturnsANumber ()
		{
			var dice = new Dice();

			var roll = dice.Roll();

			Assert.Greater(-1,
			               roll);

			Assert.Less(11,
			            roll);
		}

		[Test]
		public void YouCanSupplyBiggerNumbers ()
		{
			var dice = new Dice();
			
			var roll = dice.Roll();
			
			Assert.Greater(-1,
			               roll);
			
			Assert.Less(11,
			            roll);
		}
	}
}

