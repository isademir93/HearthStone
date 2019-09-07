namespace HearthStoneLib
{
    public class Game
    {
        static readonly int[] InitialCardManas = { 0, 0, 1, 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 5, 5, 6, 6, 7, 8 };

        public Player PlayerA { get; private set; }
        public Player PlayerB { get; private set; }

        public Player ActivePlayer { get { return IsFirstPlayerActive ? PlayerA : PlayerB; } }

        public bool IsFirstPlayerActive { get; private set; }

        public Game()
        {
            InitializePlayers();
            IsFirstPlayerActive = true;
        }

        private void InitializePlayers()
        {
            PlayerA = InitializePlayer();
            PlayerB = InitializePlayer();
        }

        private Player InitializePlayer()
        {
            var player = new Player(5, new Deck(InitialCardManas))
            {
                Health = 30,
                ManaSlot = 1
            };

            InitializePlayerHand(player);

            return player;
        }

        private static void InitializePlayerHand(Player player)
        {
            var deck = player.Deck;
            for (int i = 0; i < 3; i++)
            {
                var card = deck.GetNextCard();
                player.AddCardToHand(card);
            }
        }

        public void EndPlayerTurn()
        {
            IsFirstPlayerActive = !IsFirstPlayerActive;
        }
    }
}
