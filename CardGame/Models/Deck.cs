using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Models
{
    public abstract class Deck
    {
        protected List<PlayingCard> fullDeck = new List<PlayingCard>();
        protected List<PlayingCard> drawPile = new List<PlayingCard>();
        protected List<PlayingCard> discardPile = new List<PlayingCard>();
       
        protected void CreateDeck()
        {
            fullDeck.Clear();
            foreach (var suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (var value in Enum.GetValues(typeof(CardValue)))
                {
                    fullDeck.Add(new PlayingCard { Suit = (CardSuit)suit, Value = (CardValue)value});
                }
            }
        }

        public virtual void ShuffleDeck()
        {
            var rnd = new Random();
            drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
        }

        public abstract List<PlayingCard> DealCards();

        protected virtual PlayingCard DrawOneCard()
        {
            PlayingCard output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }
    }
}
