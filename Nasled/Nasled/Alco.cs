using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{
    public enum Tip { Виски, Коньяк, Водка, Вино, Джин, Сэм };  
    
    class Alco : Drinks
    {
       private  double percent;
       public Tip tip = Tip.Виски;
       
       public Alco() 
        {
            percent = 0;
        
            tip = Tip.Виски;
        }
      
        public override String GetInfo() 
        {
            
            var str = "Раздел:\tАлкоголь";
           
            str += String.Format("\nТип алкоколя: {0} ", tip);
            str += base.GetInfo();
            str += String.Format("\nПроцент крепости: {0} % ",percent);
            return str;
        }
        public static Alco Generator() 
        {
          
            return new Alco
            {
                volume = 0.2 + rnd.Next() % (3.5), 
                percent = 6 + rnd.Next() % 50, 
                tip = (Tip)rnd.Next(4),
                

            };

        }
    }
}
