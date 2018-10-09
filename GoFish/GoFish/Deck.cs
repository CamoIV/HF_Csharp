using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for(int suit = 0; suit <= 3; suit++)
            {
                for(int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card((Suits)suit, (Values)value));
                }
            }
        }

        public Deck(IEnumerable<Card> intialCards)
        {
            cards = new List<Card>(intialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card cardToDeal = cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }

        public Card Deal()
        {
            return Deal(0);
        }

        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();

            while(cards.Count > 0)
            {
                int cardToMove = random.Next(cards.Count);
                newCards.Add(cards[cardToMove]);
                cards.RemoveAt(cardToMove);
            }
            cards = newCards;
        }

        public IEnumerable<string> GetCardNames()
        {
            List<string> cardNames = new List<string>();
            foreach(Card card in cards)
            {
                cardNames.Add(card.Name);
            }

            return cardNames;
        }
        
        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }
        public bool ContainsValue(Values value)
        {
            foreach(Card card in cards)
            {
                if(card.Value == value)
                {
                    return true;
                }
            }
            return false;
        }
        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for(int i = cards.Count - 1; i >= 0; i--)
            {
                if(cards[i].Value == value)
                {
                    deckToReturn.Add(Deal(i));
                }
            }
            return deckToReturn;
        }
        public void Sort()
        {
            cards.Sort(new CardComparer_byValue());
        }
    }
}
