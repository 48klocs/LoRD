using System;
using System.Linq;

namespace LoRD.Model
{
	public class Dice
	{
		private readonly Random _random;

		public Dice ()
		{
			_random = new Random();
			this.Minimum = 0;
			this.Maximum = 10;
			this.NumberOfRolls = 1;
		}

		public int Roll ()
		{
			return Enumerable.Range(0, this.NumberOfRolls)
				.Select(i => _random.Next(this.Minimum, this.Maximum))
				.Max();
		}

		private int _minimum;
		public int Minimum {
			get {
				return _minimum;
			}
			set {
				_minimum = this.NormalizeMin (value);
			}
		}

		public int NormalizeMin (int min)
		{
			return (min < 0) ?
				0 :
				min;
		}

		private int _maximum;
		public int Maximum {
			get {
				return _maximum;
			}
			set {
				_maximum = this.NormalizeMax (value);
			}
		}

		public int NormalizeMax (int max)
		{
			return (max < 1) ? 
				1 :
				max;
		}

		private int _numberOfRolls;
		public int NumberOfRolls {
			get {
				return _numberOfRolls;
			}
			set {
				_numberOfRolls = this.NormalizeNumberOfRolls (value);
			}
		}

		public int NormalizeNumberOfRolls (int numberOfRolls)
		{
			return (numberOfRolls < 1) ? 
				1 :
				numberOfRolls;
		}
	}
}

