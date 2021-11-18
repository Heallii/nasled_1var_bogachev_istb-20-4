using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{
    public enum TipGaza {Кола, Фанта, СевенАп, Спрайт }; 
    class Soda : Drinks
    {
        public TipGaza nameSoda = TipGaza.Фанта;
        private int bubbles;

        public Soda() 
        {
           
            nameSoda = TipGaza.Кола;
            bubbles = 0;
        }
     

        public override String GetInfo()  
        {
           
            var str = "Раздел:\tГазировка";
            str += String.Format("\nМарка газировки: {0} ", this.nameSoda);
            str += base.GetInfo();
            str += String.Format("\nКол-во пузырьков: {0} ", this.bubbles);
            return str;
        }
        public static Soda Generator()
        {
            return new Soda
            {
                volume = 0.2 + rnd.Next() % (3.5),
                bubbles = 1000 + rnd.Next() % 3500,
                nameSoda = (TipGaza)rnd.Next(3)
            };

        }
    }
}
