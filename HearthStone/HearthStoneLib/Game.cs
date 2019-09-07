namespace HearthStoneLib
{
    public class Game
    {
        static readonly int[] InitialCardManas = { 0, 0, 1, 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 5, 5, 6, 6, 7, 8 };

        public Player PlayerA { get; private set; }
        public Player PlayerB { get; private set; }

        public Player AttackerPlayer { get { return GetPlayer(IsFirstPlayerActive); } }
        public Player DefenderPlayer { get { return GetPlayer(!IsFirstPlayerActive); } }

        public bool IsFirstPlayerActive { get; private set; }

        public bool GameOver { get; private set; }

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
                ManaSlot = 1,
                AcquiredCardFromDeckInTurn = true
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

        private Player GetPlayer(bool isFirstPlayer)
        {
            return isFirstPlayer ? PlayerA : PlayerB;
        }

        public bool EndPlayerTurn()
        {
            if (!GameOver)
            {
                AttackerPlayer.AcquiredCardFromDeckInTurn = false;
                IsFirstPlayerActive = !IsFirstPlayerActive;
            }

            return !GameOver;
        }

        public AttackResult Attack(int selectedHandCardIndex)
        {
            if (!GameOver)
            {
                var attacker = AttackerPlayer;

                if (attacker.AcquiredCardFromDeckInTurn)
                {
                    var defender = DefenderPlayer;

                    var attackCard = attacker.Hand[selectedHandCardIndex];
                    if (attackCard != null)
                    {
                        var mana = attackCard.ManaCost;
                        if (attacker.ManaSlot >= mana)
                        {
                            attacker.ManaSlot -= mana;
                            defender.Health -= mana;

                            attacker.Hand[selectedHandCardIndex] = null;

                            if (defender.Health <= 0)
                            {
                                GameOver = true;
                                return AttackResult.SuccessGameEnd;
                            }

                            return AttackResult.Success;
                        }

                        return AttackResult.InsufficientMana;
                    }

                    return AttackResult.InvalidCardIndex;
                }

                return AttackResult.NotAcquiredCardFromDeck;
            }

            return AttackResult.GameOver;
        }

        public AcquiredCardFromDeckResult AcquireCardFromDeck()
        {
            if (!GameOver)
            {
                var attacker = AttackerPlayer;
                if (!attacker.AcquiredCardFromDeckInTurn)
                {
                    attacker.AcquiredCardFromDeckInTurn = true;

                    var newCard = attacker.Deck.GetNextCard();

                    if (newCard != null)
                    {
                        if (attacker.EmptySlotCount > 0)
                        {
                            attacker.AddCardToHand(newCard);
                            return AcquiredCardFromDeckResult.Success;
                        }

                        return AcquiredCardFromDeckResult.HandIsFull;
                    }

                    return AcquiredCardFromDeckResult.DeckIsEmpty;
                }

                return AcquiredCardFromDeckResult.AlreadyAquired;
            }

            return AcquiredCardFromDeckResult.GameOver;
        }
    }
}
