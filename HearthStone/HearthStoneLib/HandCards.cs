using System.Linq;

namespace HearthStoneLib
{
    public interface IHand
    {
        ICard[] Cards { get; }

        int EmptySlotCount { get; }

        bool AddCard(ICard card);
    }

    internal class Hand : IHand
    {
        public ICard[] Cards { get; private set; }

        public Hand(int handSize)
        {
            Cards = new ICard[handSize];
        }

        public int EmptySlotCount { get { return Cards.Count(c => c == null); } }

        public bool AddCard(ICard card)
        {
            if (EmptySlotCount > 0)
            {
                for (int i = 0; i < Cards.Length; i++)
                {
                    if (Cards[i] == null)
                    {
                        Cards[i] = card;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
