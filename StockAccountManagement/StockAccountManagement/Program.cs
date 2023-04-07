namespace StockAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr how many stock do you want to add");
            int number = Convert.ToInt32(Console.ReadLine());
           
            //Stock stocks = new Stock();
            StockPortfolio stockPortfolio= new StockPortfolio();
            for (int i = 0; i < number; i++)
            {
                stockPortfolio.AddStock();
                stockPortfolio.StockView();
            }
           // stockPortfolio.GetTotalValue();
            
            //stockPortfolio.TotalValue();
            //Stock.ValueOfStock();
            //Stock.TotalValue();

        }
    }
}