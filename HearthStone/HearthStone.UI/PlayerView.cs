using HearthStoneLib;
using System.Windows.Forms;

namespace HearthStone.UI
{
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

        CardView[] Cards { get; set; }

        public IPlayer Player
        {
            get => player;
            set
            {
                player = value;

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

        private void RenderView()
        {
            if (!initializing)
            {
                cardPanel.Left = ViewType == PlayerViewType.Left ? 197 : 0;
                deck.Left = ViewType == PlayerViewType.Left ? 3 : 204;
                infoPanel.Left = ViewType == PlayerViewType.Left ? 3 : 127;                
            }
        }
    }
}
