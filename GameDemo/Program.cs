using System;

namespace GameDemo
{
    public class Program
    {
        static void Main(String[] args)
        {
            Customer customer = new("13213212311", "Name", "Surname", 2000);
            customer.Balance = 200;

            Game game = new("Assasin's Creed", "FPS", 250.3f);

            CustomerManager customerManager = new();
            if (customerManager.Register(customer))
            {
                GameManager gameManager = new();
                gameManager.saveGame(game);
                gameManager.PurchaseGame(customer,game);
                Console.WriteLine(customer.Balance);
            }
            

            
        }
    }
}