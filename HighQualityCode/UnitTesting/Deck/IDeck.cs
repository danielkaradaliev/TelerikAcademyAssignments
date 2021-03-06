﻿namespace Deck
{
    using Cards;

    public interface IDeck
    {
        Card GetTrumpCard { get; }

        int CardsLeft { get; }

        Card GetNextCard();

        void ChangeTrumpCard(Card newCard);
    }
}
