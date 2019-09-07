using HearthStoneLib;
using System.Windows.Forms;

namespace HearthStone.UI
{
    public delegate void PlayerCardClicked(IPlayer player, int cardIndex);
    public delegate void PlayerDeckClicked(IPlayer player);

    public enum PlayerViewType
    {
        Left,
        Right
    }

    public partial class PlayerView : UserControl
    {
        IPlayer player;
        PlayerViewType viewType;

        bool initializing;

        public event PlayerCardClicked CardClicked;
        public event PlayerDeckClicked DeckClicked;

        CardView[] Cards { get; set; }

        public IPlayer Player
        {
            get => player;
            set
            {
                player = value;


                deck.Deck = player?.Deck;

                for (int i = 0; i < Cards.Length; i++)
                {
                    var card = Cards[i];
                    card.CardIndex = i;
                    card.Hand = player?.Hand;
                }

                RenderView();
            }
        }

        public PlayerViewType ViewType
        {
            get => viewType;
            set
            {
                viewType = value;

                RenderView();
            }
        }

        public PlayerView()
        {
            InitializeComponent();

            Cards = new CardView[] { cardView1, cardView2, cardView3, cardView4, cardView5 };

            for (int i = 0; i < Cards.Length; i++)
            {
                Cards[i].CardIndex = i;
            }
        }

        public PlayerView(IPlayer player, PlayerViewType viewType)
        {
            InitializeComponent();

            initializing = true;
            try
            {
                Player = player;
                ViewType = ViewType;
            }
            finally
            {
                initializing = false;
            }

            RenderView();
        }

        public void RenderView()
        {
            if (!initializing)
            {
                cardPanel.Left = ViewType == PlayerViewType.Left ? 197 : 0;
                deck.Left = ViewType == PlayerViewType.Left ? 3 : 204;
                infoPanel.Left = ViewType == PlayerViewType.Left ? 3 : 127;

                healthValueLabel.Text = Player != null ? Player.Health.ToString() : string.Empty;
                manaValueLabel.Text = Player != null ? Player.TurnMana.ToString() : string.Empty;

                deck.RenderView();

                foreach (var card in Cards)
                {
                    card.RenderView();
                }
            }
        }

        private void CardView_CardClicked(int cardIndex)
        {
            CardClicked?.Invoke(Player, cardIndex);
        }

        private void deck_DeckClicked()
        {
            DeckClicked?.Invoke(Player);
        }
    }
}
