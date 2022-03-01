using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    public class GameManager
    {
        private List<Game> GameList { get;}

        public GameManager()
        {
            GameList = new List<Game>();
        }

        public void saveGame(Game game)
        {
            if (game == null)
            {
                GameList.Add(game);
            }
        }
        public Game GetGameById(int id)
        {
            foreach (Game game in GameList)
            {
                if(game.Id == id)
                {
                    return game;
                }
            }
            return null;
        }

        public Game GetGameByName(string name)
        {
            foreach(Game game in GameList)
            {
                if (game.Name.Equals(name))
                {
                    return game;
                }
            }
            return null;
        }

        public bool PurchaseGame(Customer Customer, Game Game)
        {
            float CostOfGame = Customer.Balance;
            if(Game.Campaign != null)
            {
                CostOfGame = CostOfGame * Game.Campaign.Ratio;
            }
            if(CostOfGame >= Game.Price)
            {
                Customer.Balance = CostOfGame - Game.Price;
                Console.WriteLine("Satin Alma Basarili!");
                return true;
            }
            else
            {
                Console.WriteLine("Bakiyeniz Yetersiz!");
                return false;
            }
        }

    }
}
