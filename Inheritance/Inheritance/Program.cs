using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            Console.ReadLine();





    //        Deck deck = new Deck();
    //        deck.Shuffle(3);

    //        foreach (Card card in deck.Cards)
    //        {
    //            Console.WriteLine(card.Face + "of" + card.Suit);
    //        }
    //        Console.WriteLine(deck.Cards.Count);
    //        Console.ReadLine();
    //    }
    //}
}
