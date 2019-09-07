using System;

namespace HearthStoneLib
{
    public delegate void GameOverEventHandler(IPlayer winner);

    public interface IHearthStoneGame
    {
        IPlayer PlayerA { get; }
        IPlayer PlayerB { get; }

        IPlayer ActivePlayer { get; }

        bool IsFirstPlayerActive { get; }

        bool GameOver { get; }

        event GameOverEventHandler GameOvered;

        AcquiredCardFromDeckResult AcquireCardFromDeck();

        AttackResult Attack(int selectedHandCardIndex);

        bool EndPlayerTurn();
    }

    public class HearthStoneGame : IHearthStoneGame
    {
        static readonly int[] InitialCardManas = { 0, 0, 1, 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 5, 5, 6, 6, 7, 8 };

        public IPlayer PlayerA { get; private set; }
        public IPlayer PlayerB { get; private set; }

        public IPlayer ActivePlayer { get { return AttackerPlayer; } }

        Player AttackerPlayer { get { return GetPlayer(IsFirstPlayerActive); } }

        Player DefenderPlayer { get { return GetPlayer(!IsFirstPlayerActive); } }

        public bool IsFirstPlayerActive { get; private set; }

        public event GameOverEventHandler GameOvered;

        private bool gameOver;
        public bool GameOver
        {
            get => gameOver;
            private set
            {
                gameOver = value;

                if (gameOver)
                {
                    GameOvered?.Invoke(PlayerA.Health <= 0 ? PlayerB : PlayerA);
                }
            }
        }


        private HearthStoneGame()
        {
            InitializePlayers();
            SetAttacker(true);
        }

        public static IHearthStoneGame CreateGame()
        {
            return new HearthStoneGame();
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
                player.Hand.AddCard(card);
            }
        }

        private Player GetPlayer(bool isFirstPlayer)
        {
            return isFirstPlayer ? (Player)PlayerA : (Player)PlayerB;
        }

        public bool EndPlayerTurn()
        {
            if (!GameOver)
            {
                var attacker = AttackerPlayer;
                attacker.ManaSlot = Math.Min(attacker.ManaSlot + 1, 10);
                attacker.AcquiredCardFromDeckInTurn = false;

                SetAttacker(!IsFirstPlayerActive);
            }

            return !GameOver;
        }

        private void SetAttacker(bool isFirstPlayer)
        {
            IsFirstPlayerActive = isFirstPlayer;

            var attacker = AttackerPlayer;
            attacker.TurnMana = attacker.ManaSlot;
        }

        public AttackResult Attack(int selectedHandCardIndex)
        {
            if (!GameOver)
            {
                var attacker = AttackerPlayer;

                if (attacker.AcquiredCardFromDeckInTurn)
                {
                    var defender = DefenderPlayer;

                    var attackCard = attacker.Hand.Cards[selectedHandCardIndex];
                    if (attackCard != null)
                    {
                        var mana = attackCard.ManaCost;
                        if (attacker.TurnMana >= mana)
                        {
                            attacker.TurnMana -= mana;
                            defender.Health -= mana;

                            attacker.Hand.Cards[selectedHandCardIndex] = null;

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
                        if (attacker.Hand.EmptySlotCount > 0)
                        {
                            attacker.Hand.AddCard(newCard);
                            return AcquiredCardFromDeckResult.Success;
                        }

                        return AcquiredCardFromDeckResult.HandIsFull;
                    }

                    attacker.Health--;

                    if (attacker.Health <= 0)
                    {
                        GameOver = true;
                        return AcquiredCardFromDeckResult.GameOver;
                    }

                    return AcquiredCardFromDeckResult.DeckIsEmpty;
                }

                return AcquiredCardFromDeckResult.AlreadyAquired;
            }

            return AcquiredCardFromDeckResult.GameOver;
        }
    }
}
