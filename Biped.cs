using System;
namespace _2_POO_Lheritage
{
	public abstract class Biped : Animal
	{
		public Biped() : base(2, true)
		{ }

		public override void Move()
		{
			Console.WriteLine("Walking on 2 legs");
		}
	}
}

