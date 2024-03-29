﻿namespace HearthStoneLib
{
    public interface IPlayer
    {
        bool AcquiredCardFromDeckInTurn { get; }

        int Health { get; set; }

        int ManaSlot { get; }

        int TurnMana { get; }

        IHand Hand { get; }

        IDeck Deck { get; }
    }

    internal class Player : IPlayer
    {
        public int Health { get; set; }

        public int ManaSlot { get; internal set; }

        public int TurnMana { get; internal set; }

        public IHand Hand { get; private set; }

        public IDeck Deck { get; private set; }

        public bool AcquiredCardFromDeckInTurn { get; internal set; }

        public Player(int handSize, Deck deck)
        {
            Hand = new Hand(handSize);
            Deck = deck;
        }
    }
}
