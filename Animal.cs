using System;
namespace _2_POO_Lheritage
{
	public abstract class Animal
	{
        protected short _legsCount;
		protected bool _hairy;

        public Animal(short legsCount, bool hairy)
		{
			_legsCount = legsCount;
			_hairy = hairy;
		}

		public abstract void Move();

		public virtual void Eat()
		{
			Console.WriteLine("Eating food");
		}
	}
}

