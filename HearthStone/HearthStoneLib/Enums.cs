namespace HearthStoneLib
{
    public enum AttackResult
    {
        GameOver,
        NotAcquiredCardFromDeck,
        InvalidCardIndex,
        InsufficientMana,
        Success,
        SuccessGameEnd
    }

    public enum AcquiredCardFromDeckResult
    {
        GameOver,
        AlreadyAquired,
        HandIsFull,
        DeckIsEmpty,
        Success
    }
}
