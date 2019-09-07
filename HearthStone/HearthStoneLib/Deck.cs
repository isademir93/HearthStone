using System.Collections.Generic;

namespace HearthStoneLib
{
    public interface IDeck
    {
        ICard GetNextCard();
    }

    internal class Deck : IDeck
    {
        private Stack<Card> Cards { get; set; }

        public Deck(int[] cards)
        {
            var shuffledCardList = new List<int>(cards);
            shuffledCardList.Shuffle();

            foreach (var item in shuffledCardList)
            {
                Cards.Push(new Card(item));
            }
        }

        public ICard GetNextCard()
        {
            if (Cards.Count > 0)
            {
                return Cards.Pop();
            }

            return null;
        }
    }
}
