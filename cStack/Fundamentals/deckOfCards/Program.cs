using System;

namespace deckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.shuffle();
        
            Player me = new Player("jeremy");
            me.Draw(newDeck);
            me.Draw(newDeck);
            me.Draw(newDeck);
            Console.WriteLine(me.hand.Count);
            foreach (var card in me.hand)
            {
                Console.WriteLine(card.stringVal +" "+ card.cardSuit);
            }
            Console.WriteLine("---------------------------------------------------");
            me.Discard(0);
            Console.WriteLine(me.hand.Count);
            foreach (var card in me.hand)
            {
                Console.WriteLine(card.stringVal +" "+ card.cardSuit);
            }
            me.Discard(4);

        }
    }
}
