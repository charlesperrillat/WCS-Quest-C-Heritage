using System;
namespace _2_POO_Lheritage
{
	public class Tortoise : Quadruped
	{
		private string _color;

		public Tortoise(string color) : base()
		{
			_color = color;
		}

        public string GetColor()
        {
            return _color;
        }
    }
}

