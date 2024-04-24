using System;
namespace _2_POO_Lheritage
{
	public abstract class Quadruped : Animal
	{
		public Quadruped() : base (4, false)
		{
		}

        public override void Move()
        {
            Console.WriteLine("Walking on 4 legs");
        }
    }
}

