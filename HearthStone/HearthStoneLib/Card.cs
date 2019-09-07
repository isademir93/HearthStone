namespace HearthStoneLib
{
    public interface ICard
    {
        int ManaCost { get; }
    }

    internal class Card : ICard
    {
        public int ManaCost { get; private set; }

        internal Card(int manaCost)
        {
            ManaCost = manaCost;
        }
    }
}
