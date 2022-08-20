using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Models;

namespace CardGame
{
    public abstract class Deck
    {
        protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();
        protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();
        protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();

        protected void CreateDeck()
        {
            fullDeck.Clear();
            foreach (var suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (var value in Enum.GetValues(typeof(CardValue)))
                {
                    fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (CardValue)value });
                }
            }
        }

        public virtual void ShuffleDeck()
        {
            var rnd = new Random();
            drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
        }

        public abstract List<PlayingCardModel> DealCards();

        protected virtual PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }
    }
}
