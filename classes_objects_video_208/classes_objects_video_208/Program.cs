using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";
            Deck deck = new Deck();
            int timesShuffled = 0;
            //deck = Shuffle(deck);
            deck = Shuffle(deck, out timesShuffled, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }


        //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
        //Console.ReadLine();



        ////foreach (Card card in deck.Cards)
        ////{
        ////}
        ////Console.WriteLine(deck.Cards.Count);
        ////Console.ReadLine();
        ////Console.WriteLine(card.Face + " of " + card.Suit);







        ////Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
        ////Console.ReadLine();



        public static Deck Shuffle(Deck deck)
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                deck = Shuffle(deck);
            }
            return deck;
        }

    }               
    
}
        
    
