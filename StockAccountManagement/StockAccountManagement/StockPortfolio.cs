using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    internal class StockPortfolio
    {
        public static List<Stock> stock = new List<Stock>();

        public void AddStock()
        {
            Stock stocks = new Stock();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enetr the Stock Name");
            stocks.stockName = Console.ReadLine();
            Console.WriteLine("enter the number of stock");
            stocks.numberOfStock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr the StockPrice");
            stocks.stockPrice = Convert.ToInt32(Console.ReadLine());

           stock.Add(stocks);
        }

        public float GetTotalValue()
        {
            float totalValue = 0;
            foreach(Stock stocks in stock)
            {
                totalValue = stocks.TotalValue();
            }
            return totalValue;
        }

        public void StockView()
        {
            Console.WriteLine("***********Stock Market ***************");
            foreach(Stock stocks in stock)
            {
                float value = stocks.TotalValue();
                Console.WriteLine("Stock NAme:" + stocks.stockName);
                Console.WriteLine("Number of Stocks:" + stocks.numberOfStock);
                Console.WriteLine("Stock Price:" + stocks.stockPrice);
              
                float totalStock = GetTotalValue();
                Console.WriteLine("Total number of stock is:" + totalStock);

                Console.WriteLine("---------------------------");
            }

        }

    }
}
