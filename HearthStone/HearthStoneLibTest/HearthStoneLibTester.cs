using HearthStoneLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace HearthStoneLibTest
{
    [TestClass]
    public class HearthStoneLibTester
    {
        [TestMethod]
        public void CreatedGameShouldNotBeNull()
        {
            var game = HearthStoneGame.CreateGame();

            Assert.IsNotNull(game);
        }

        [TestMethod]
        public void PlayerAShouldNotBeNull()
        {
            var game = HearthStoneGame.CreateGame();

            Assert.IsNotNull(game.PlayerA);
        }

        [TestMethod]
        public void PlayerBShouldNotBeNull()
        {
            var game = HearthStoneGame.CreateGame();

            Assert.IsNotNull(game.PlayerB);
        }

        [TestMethod]
        public void PlayerADeckShouldNotBeNull()
        {
            var game = HearthStoneGame.CreateGame();
            var deck = game.PlayerA.Deck;

            Assert.IsNotNull(deck);
        }

        [TestMethod]
        public void PlayerBDeckShouldNotBeNull()
        {
            var game = HearthStoneGame.CreateGame();
            var deck = game.PlayerB.Deck;

            Assert.IsNotNull(deck);
        }

        [TestMethod]
        public void InitialDeckACardCountShouldBe17()
        {
            var game = HearthStoneGame.CreateGame();
            var deck = game.PlayerA.Deck;

            Assert.AreEqual(deck.Count, 17);
        }

        [TestMethod]
        public void InitialDeckBCardCountShouldBe17()
        {
            var game = HearthStoneGame.CreateGame();
            var deck = game.PlayerB.Deck;

            Assert.AreEqual(deck.Count, 17);
        }

        [TestMethod]
        public void DeckASouldGiveNotNullInitialCountCardsAndOthersShouldBeNull()
        {
            var game = HearthStoneGame.CreateGame();
            var deck = game.PlayerA.Deck;
            var count = deck.Count;
            for (int i = 0; i < count; i++)
            {
                var card = deck.GetNextCard();
                Assert.IsNotNull(card);
            }
            var nullCard = deck.GetNextCard();
            Assert.IsNull(nullCard);
        }

        [TestMethod]
        public void DeckBSouldGiveNotNullInitialCountCardsAndOthersShouldBeNull()
        {
            var game = HearthStoneGame.CreateGame();
            var deck = game.PlayerB.Deck;
            var count = deck.Count;
            for (int i = 0; i < count; i++)
            {
                var card = deck.GetNextCard();
                Assert.IsNotNull(card);
            }
            var nullCard = deck.GetNextCard();
            Assert.IsNull(nullCard);
        }

        [TestMethod]
        public void InitialPlayerAHandShouldNotBeNull()
        {
            var game = HearthStoneGame.CreateGame();
            var hand = game.PlayerA.Hand;

            Assert.IsNotNull(hand);
        }

        [TestMethod]
        public void InitialPlayerBHandShouldNotBeNull()
        {
            var game = HearthStoneGame.CreateGame();
            var hand = game.PlayerB.Hand;

            Assert.IsNotNull(hand);
        }

        [TestMethod]
        public void InitialPlayerAHandCardsShouldNotBeNull()
        {
            var game = HearthStoneGame.CreateGame();
            var cards = game.PlayerA.Hand.Cards;

            Assert.IsNotNull(cards);
        }

        [TestMethod]
        public void InitialPlayerBHandCardsShouldNotBeNull()
        {
            var game = HearthStoneGame.CreateGame();
            var cards = game.PlayerB.Hand.Cards;

            Assert.IsNotNull(cards);
        }

        [TestMethod]
        public void InitialPlayerAHandSizeShouldBe5()
        {
            var game = HearthStoneGame.CreateGame();
            var hand = game.PlayerA.Hand;

            Assert.AreEqual(hand.Cards.Length, 5);
        }

        [TestMethod]
        public void InitialPlayerBHandSizeShouldBe5()
        {
            var game = HearthStoneGame.CreateGame();
            var hand = game.PlayerB.Hand;

            Assert.AreEqual(hand.Cards.Length, 5);
        }

        [TestMethod]
        public void InitialPlayerAHandShouldHave3Cards()
        {
            var game = HearthStoneGame.CreateGame();
            var cards = game.PlayerA.Hand.Cards;
            var cardCount = cards.Count(c => c != null);
            Assert.AreEqual(cardCount, 3);
        }

        [TestMethod]
        public void InitialPlayerBHandShouldHave3Cards()
        {
            var game = HearthStoneGame.CreateGame();
            var cards = game.PlayerB.Hand.Cards;
            var cardCount = cards.Count(c => c != null);
            Assert.AreEqual(cardCount, 3);
        }

        [TestMethod]
        public void InitialPlayerAHandEmptySlotShouldBe2()
        {
            var game = HearthStoneGame.CreateGame();
            var hand = game.PlayerA.Hand;

            Assert.AreEqual(hand.EmptySlotCount, 2);
        }

        [TestMethod]
        public void InitialPlayerBHandEmptySlotShouldBe2()
        {
            var game = HearthStoneGame.CreateGame();
            var hand = game.PlayerB.Hand;

            Assert.AreEqual(hand.EmptySlotCount, 2);
        }

        [TestMethod]
        public void CardShouldNotBeNull()
        {
            var game = HearthStoneGame.CreateGame();
            var card = game.PlayerA.Deck.GetNextCard();

            Assert.IsNotNull(card);
        }

        [TestMethod]
        public void CardManaCostShouldGreaterOrEqualZero()
        {
            var game = HearthStoneGame.CreateGame();
            var card = game.PlayerA.Deck.GetNextCard();

            Assert.IsTrue(card.ManaCost >= 0);
        }

        [TestMethod]
        public void InitialPlayerAHelathShouldBe30()
        {
            var game = HearthStoneGame.CreateGame();

            Assert.AreEqual(game.PlayerA.Health, 30);
        }

        [TestMethod]
        public void InitialPlayerBHelathShouldBe30()
        {
            var game = HearthStoneGame.CreateGame();

            Assert.AreEqual(game.PlayerB.Health, 30);
        }

        [TestMethod]
        public void InitialPlayerAManaSlotShouldBe1()
        {
            var game = HearthStoneGame.CreateGame();

            Assert.AreEqual(game.PlayerA.ManaSlot, 1);
        }

        [TestMethod]
        public void InitialPlayerBManaSlotShouldBe1()
        {
            var game = HearthStoneGame.CreateGame();

            Assert.AreEqual(game.PlayerB.ManaSlot, 1);
        }

        [TestMethod]
        public void PlayerAShouldHaveSpecificManaCostDamageCards()
        {
            var manaCosts = new List<int>(new int[] { 0, 0, 1, 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 5, 5, 6, 6, 7, 8 });
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerA;
            var hand = player.Hand;
            var deck = player.Deck;

            foreach (var handCard in hand.Cards)
            {
                if (handCard != null)
                {
                    Assert.IsTrue(manaCosts.Contains(handCard.ManaCost));
                    manaCosts.Remove(handCard.ManaCost);
                }
            }

            var deckCount = deck.Count;
            for (int i = 0; i < deckCount; i++)
            {
                var deckCard = deck.GetNextCard();
                Assert.IsNotNull(deckCard);
                Assert.IsTrue(manaCosts.Contains(deckCard.ManaCost));
                manaCosts.Remove(deckCard.ManaCost);
            }

            Assert.AreEqual(manaCosts.Count, 0);
        }

        [TestMethod]
        public void PlayerBShouldHaveSpecificManaCostDamageCards()
        {
            var manaCosts = new List<int>(new int[] { 0, 0, 1, 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 5, 5, 6, 6, 7, 8 });
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerB;
            var hand = player.Hand;
            var deck = player.Deck;

            foreach (var handCard in hand.Cards)
            {
                if (handCard != null)
                {
                    Assert.IsTrue(manaCosts.Contains(handCard.ManaCost));
                    manaCosts.Remove(handCard.ManaCost);
                }
            }

            var deckCount = deck.Count;
            for (int i = 0; i < deckCount; i++)
            {
                var deckCard = deck.GetNextCard();
                Assert.IsNotNull(deckCard);
                Assert.IsTrue(manaCosts.Contains(deckCard.ManaCost));
                manaCosts.Remove(deckCard.ManaCost);
            }

            Assert.AreEqual(manaCosts.Count, 0);
        }

        [TestMethod]
        public void PlayerAManaSlotShouldIncrementBy1EveryTurn()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerA;

            game.EndPlayerTurn();
            game.EndPlayerTurn();

            var manaSlot = player.ManaSlot;
            for (int i = 0; i < 5; i++)
            {
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();

                Assert.AreEqual(manaSlot + 1, player.ManaSlot);
                manaSlot = player.ManaSlot;
            }
        }

        [TestMethod]
        public void PlayerBManaSlotShouldIncrementBy1EveryTurn()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerB;
            game.EndPlayerTurn();
            game.EndPlayerTurn();

            var manaSlot = player.ManaSlot;
            for (int i = 0; i < 5; i++)
            {
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();

                Assert.AreEqual(manaSlot + 1, player.ManaSlot);
                manaSlot = player.ManaSlot;
            }
        }

        [TestMethod]
        public void PlayerAManaSlotShouldBeMaximum10()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerA;

            game.EndPlayerTurn();
            game.EndPlayerTurn();

            for (int i = 0; i < 20; i++)
            {
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();
            }

            Assert.AreEqual(player.ManaSlot, 10);
        }

        [TestMethod]
        public void PlayerBManaSlotShouldBeMaximum10()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerB;
            game.EndPlayerTurn();
            game.EndPlayerTurn();

            for (int i = 0; i < 20; i++)
            {
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();
            }

            Assert.AreEqual(player.ManaSlot, 10);
        }

        [TestMethod]
        public void PlayerATurnManaShouldBeEqualToPlayerManaSlotEveryTurn()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerA;

            for (int i = 0; i < 20; i++)
            {
                game.EndPlayerTurn();
                game.EndPlayerTurn();
                Assert.AreEqual(player.TurnMana, player.ManaSlot);
            }
        }

        [TestMethod]
        public void PlayerBTurnManaShouldBeEqualToPlayerManaSlotEveryTurn()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerB;
            game.EndPlayerTurn();
            game.EndPlayerTurn();
            game.AcquireCardFromDeck();
            game.EndPlayerTurn();

            for (int i = 0; i < 20; i++)
            {
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();
                Assert.AreEqual(player.TurnMana, player.ManaSlot);
            }
        }

        [TestMethod]
        public void PlayerCanAttackAsHeCanAfford()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerA;
            var enemy = game.PlayerB;

            bool successAttackTested = false;
            bool insufficientManaCostTested = false;
            while (!game.GameOver && !successAttackTested && !insufficientManaCostTested)
            {
                var hand = player.Hand;
                var deck = player.Deck;

                var cards = hand.Cards
                    .Select((card, index) => new { Index = index, Card = card })
                    .Where(c => c.Card != null)
                    .ToList();
                foreach (var card in cards)
                {
                    var manaCost = card.Card.ManaCost;
                    var turnMana = player.TurnMana;
                    var enemyHealth = enemy.Health;
                    var attackResult = game.Attack(card.Index);

                    if (manaCost <= turnMana)
                    {
                        var resultIsExpected = attackResult == AttackResult.Success || attackResult == AttackResult.SuccessGameEnd;
                        Assert.IsTrue(resultIsExpected);
                        Assert.AreEqual(player.TurnMana, turnMana - manaCost);
                        Assert.AreEqual(enemy.Health, enemyHealth - manaCost);
                        successAttackTested = true;
                    }
                    else
                    {
                        Assert.AreEqual(attackResult, AttackResult.InsufficientMana);
                        insufficientManaCostTested = true;
                    }
                }

                game.EndPlayerTurn();

                var playerTemp = player;
                player = enemy;
                enemy = playerTemp;
            }
        }

        [TestMethod]
        public void PlayerAHealthShouldBleedOutWhenDeckIsEmpty()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerA;
            var deck = player.Deck;
            var count = deck.Count;
            for (int i = 0; i < count; i++)
            {
                deck.GetNextCard();
            }

            game.EndPlayerTurn();
            game.EndPlayerTurn();

            var health = player.Health;
            game.AcquireCardFromDeck();
            Assert.AreEqual(player.Health, health - 1);
        }

        [TestMethod]
        public void PlayerBHealthShouldBleedOutWhenDeckIsEmpty()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerB;
            var deck = player.Deck;
            var count = deck.Count;
            for (int i = 0; i < count; i++)
            {
                deck.GetNextCard();
            }

            game.EndPlayerTurn();
            game.EndPlayerTurn();

            game.AcquireCardFromDeck();
            game.EndPlayerTurn();

            var health = player.Health;
            game.AcquireCardFromDeck();
            Assert.AreEqual(player.Health, health - 1);
        }

        [TestMethod]
        public void PlayerAHandShouldBeOverloadWhenHandIsFull()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerA;
            var deck = player.Deck;
            var hand = player.Hand;

            game.EndPlayerTurn();
            game.EndPlayerTurn();

            while (hand.EmptySlotCount > 0)
            {
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();

                game.AcquireCardFromDeck();
                game.EndPlayerTurn();
            }

            var handCardsCount = hand.Cards.Count(c => c != null);
            var deckCount = deck.Count;
            var totalCount = handCardsCount + deckCount;
            game.AcquireCardFromDeck();

            var newHandCardsCount = hand.Cards.Count(c => c != null);
            var newDeckCount = deck.Count;
            var newTotalCount = newHandCardsCount + newDeckCount;

            Assert.AreEqual(newTotalCount, totalCount - 1);
        }

        [TestMethod]
        public void PlayerBHandShouldBeOverloadWhenHandIsFull()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerB;
            var deck = player.Deck;
            var hand = player.Hand;

            game.EndPlayerTurn();
            game.EndPlayerTurn();
            game.AcquireCardFromDeck();
            game.EndPlayerTurn();

            while (hand.EmptySlotCount > 0)
            {
                game.AcquireCardFromDeck();
                game.EndPlayerTurn();

                game.AcquireCardFromDeck();
                game.EndPlayerTurn();
            }

            var handCardsCount = hand.Cards.Count(c => c != null);
            var deckCount = deck.Count;
            var totalCount = handCardsCount + deckCount;
            game.AcquireCardFromDeck();

            var newHandCardsCount = hand.Cards.Count(c => c != null);
            var newDeckCount = deck.Count;
            var newTotalCount = newHandCardsCount + newDeckCount;

            Assert.AreEqual(newTotalCount, totalCount - 1);
        }

        [TestMethod]
        public void DudCardShouldHasNoEffectOnEnemyHealth()
        {
            var game = HearthStoneGame.CreateGame();
            var player = game.PlayerA;
            var enemy = game.PlayerB;
            var hand = player.Hand;
            var handCards = hand.Cards
                    .Select((card, index) => new { Index = index, Card = card })
                    .Where(c => c.Card != null)
                    .ToList();

            var dudCard = handCards.Where(c => c.Card.ManaCost == 0).FirstOrDefault();

            while (dudCard == null)
            {
                var newCard = player.Deck.GetNextCard();
                if (newCard.ManaCost == 0)
                {
                    var emptySlotIndex = hand.Cards
                        .Select((card, index) => new { Index = index, Card = card })
                        .Where(c => c.Card == null)
                        .First().Index;

                    hand.Cards[emptySlotIndex] = newCard;

                    dudCard = new { Index = emptySlotIndex, Card = newCard };
                }
            }

            var enemyHealth = enemy.Health;
            game.Attack(dudCard.Index);

            Assert.AreEqual(enemy.Health, enemyHealth);
        }
    }
}
