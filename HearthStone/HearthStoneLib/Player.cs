using System.Linq;

namespace HearthStoneLib
{
    public class Player
    {
        public int Health { get; set; }
        public int ManaSlot { get; set; }

        public Card[] Hand { get; private set; }

        public Deck Deck { get; private set; }


        public Player(int maxHandSlotCount, Deck deck)
        {
            Hand = new Card[maxHandSlotCount];
            Deck = deck;
        }

        public int EmptySlotCount { get { return Hand.Count(c => c == null); } }

        public bool AddCardToHand(Card card)
        {
            if (EmptySlotCount > 0)
            {
                for (int i = 0; i < Hand.Length; i++)
                {
                    if (Hand[i] == null)
                    {
                        Hand[i] = card;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
