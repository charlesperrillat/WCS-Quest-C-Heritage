using System;
namespace _2_POO_Lheritage
{
	public class Monkey : Biped
	{
		private string _colorOfHairs;

		public Monkey(string colorOfHairs) : base()
		{
			_colorOfHairs = colorOfHairs;
		}

		public string GetColorOfHairs()
		{
			return _colorOfHairs;
		}
	}
}

