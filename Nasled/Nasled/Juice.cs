using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{
    public enum Fruit { Яблоко, Вишня, Ананас, Абрикос};
    class Juice : Drinks
    {
        public Fruit fruit = Fruit.Вишня;
        private bool pulp;

        public Juice() 
        {
           
            fruit = Fruit.Абрикос;
            pulp = false;
        }

      
        public override String GetInfo()
        {

            var str = "Раздел:\tСок";

            str += base.GetInfo();
            str += String.Format("\nИспользуемый фрукт: {0} ", this.fruit);
            str += String.Format("\nНаличие мякоти: {0} ", this.pulp);
            return str;
        }
        public static Juice Generator()
        {
            return new Juice
            {
                volume = 0.2 + rnd.Next() % (3.5),
                pulp = rnd.Next(2) == 0,
                fruit = (Fruit)rnd.Next(4)
            };

        }
    }

}