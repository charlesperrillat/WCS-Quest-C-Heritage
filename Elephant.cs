using System;
namespace _2_POO_Lheritage
{
	public class Elephant : Quadruped
	{
		private string _color;

		public Elephant(string color) : base()
		{
			_color = color;
		}

		public string GetColor()
		{
			return _color;
		}
	}
}

