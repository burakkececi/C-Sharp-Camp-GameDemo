using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        
        public Campaign ? Campaign { get; set; }

        public Game(string Name, string Description, float Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        }
    }
}
