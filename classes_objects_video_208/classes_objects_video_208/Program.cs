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
            deck.Shuffle(3);
            //deck = Shuffle(deck);


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
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



     
        //public static Deck Shuffle(Deck deck,  int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}

        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return;


        }
    }

        
    
