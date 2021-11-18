using System;
using System.Collections.Generic;
using System.Text;

namespace Nasled
{

    abstract class Drinks
    {
        public static Random rnd = new Random();
        public double volume;

       
        public virtual String GetInfo()
        {
            var str = String.Format("\nОбъем напитка: {0} л.", this.volume);
            return str;
        }

     
       


     }

}
