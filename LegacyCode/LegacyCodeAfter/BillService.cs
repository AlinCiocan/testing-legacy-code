/*
SCOPE: test legacy code that contains dependencies hidden
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LegacyCodeAfter
{
    public class BillService
    {
        public int CalculateTotalPriceOfProducts(List<ProductDetails> products)
        {
            /*
            HERE will find some complex calculations!!
             	
                   /\     /\
                  {  `---'  }
                  {  O   O  }
                  ~~>  V  <~~
                   \  \|/  /
                    `-----'__
                    /     \  `^\_
                   {       }\ |\_\_   W
                   |  \_/  |/ /  \_\_( )
                    \__/  /(_E     \__/
                      (  /
                       MM
            
            */





            // I actually do logging in database, but my name is Mickey Mouse
            // so you will never know what I am doing

            MickeyMouse.Say("Everything was calculated fine so far");

            
            /*
            .
            .
            .
            .
            .
            .
            .


            Some more complex stuff code..                                         _
                _._ _..._ .-',     _.._(`))
               '-. `     '  /-._.-'    ',/
                  )         \            '.
                 / _    _    |             \
                |  a    a    /              |
                \   .-.                     ;  
                 '-('' ).-'       ,'       ;
                    '-;           |      .'
                       \           \    /
                       | 7  .__  _.-\   \
                       | |  |  ``/  /`  /
                      /,_|  |   /,_/   /
                         /,_/      '`-'

            */


            var total = products.Sum(product => product.Price*product.Quantity);

            MickeyMouse.Say("The result after calculation is: " + total);

            return total;
        }
    }

    public class MickeyMouse
    {
        public static void Say(string msg)
        {
            // imagine this is hitting the database and logging the message
            Thread.Sleep(5000);
            throw new Exception("The database is not configured and this is supposed to be a unit test anyway!! Doah..");
        }
    }

    public class ProductDetails
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}