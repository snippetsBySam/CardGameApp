using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Models
{
    public class BlackJackDeck : Deck
    {
        public override List<PlayingCard> DealCards()
        {
            List<PlayingCard> output = new List<PlayingCard>();

            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }
    }
}
