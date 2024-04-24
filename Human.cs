using System;
namespace _2_POO_Lheritage
{
	public class Human : Biped
	{
		private string _colorOfEyes;

		public Human(string colorOfEyes) : base()
		{
			_colorOfEyes = colorOfEyes;
		}

        public string GetColorOfEyes()
		{
			return _colorOfEyes;
		}

    }
}

