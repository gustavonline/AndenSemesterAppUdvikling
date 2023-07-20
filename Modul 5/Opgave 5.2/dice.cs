using System;
namespace Opgave_5._2
{
	class dice
	{
		
		//attributer
		private int eyes;

		private int size;

		private Random r;

		public dice(int size)
		{
			this.size = size;
			r = new Random();
			Roll();
		}

        public int Roll()
        {
            eyes = r.Next(1, size + 1);
            return eyes;
        }

        public int Eyes { get { return eyes; } }
    }
}

