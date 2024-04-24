using System;
namespace _2_POO_Lheritage
{
	public class Lizard : Quadruped
	{
		private string _color;

		public Lizard(string color) : base()
		{
			_color = color;
		}

        public string GetColor()
        {
            return _color;
        }
    }
}

