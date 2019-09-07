namespace HearthStoneLib
{
    public class Card
    {
        public int ManaCost { get; private set; }

        public Card(int manaCost)
        {
            ManaCost = manaCost;
        }
    }
}
