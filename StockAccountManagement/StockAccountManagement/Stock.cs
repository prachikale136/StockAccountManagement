using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    internal class Stock
    {
        
        public string stockName { get; set; }
        public int numberOfStock { get; set;}
        public float stockPrice { get; set; }

        public float TotalValue()
        {
            return numberOfStock * stockPrice;
            //return valueOfStock;
        }


       
      
     /*   public static void StockView(ValueOfStock)
        {
            Console.WriteLine("Stock Name   Number Of Shares    Stock Price");
            foreach(Stock stock in stockList) 
            {
                Console.WriteLine($"{stock.stockName}\t\t{stock.numberOfStock}\t\t\t\t{stock.stockPrice}"
                    $"{valueOfStock = ValueOfStock(stock.stockPrice, stock.numberOfStock)}"); 
            }
        }*/

       /* public static float ValueOfStock(int numberOfStock , float stockPrice )
        {
            float valueOfStock = numberOfStock * stockPrice;
            return valueOfStock;
        }

        public static float TotalValue(float valueOfStock)
        {
            float totalValue = 0;
            totalValue += valueOfStock;
            return totalValue;
        }*/

    }
}
