using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        public int Value;


        public Coin(string description, int score, int value) 
        {
            Description = description;
            Score = score;
            Value = value;
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
            
        }
    }
}
