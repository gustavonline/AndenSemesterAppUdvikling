using System;
namespace Opgave_4._1
{
	class dice
	{
        public static int countDice = 0;

        private int eyes;

        private int size;

        Random r = new Random();

        public dice(int size)
        {
            this.size = size;
            Roll();
            countDice++;
        }

        public void Roll()
        {
            eyes = r.Next(1, size + 1);
        }

        public int Eyes {
            get {
                return eyes;
            }
        }
    }
}

