using HearthStoneLib;
using System;
using System.Windows.Forms;

namespace HearthStone.UI
{
    public delegate void DeckClickedEventHandler();

    public partial class DeckView : UserControl
    {
        public event DeckClickedEventHandler DeckClicked;

        private IDeck deck;

        public IDeck Deck
        {
            get => deck;
            set
            {
                deck = value;

                RenderView();
            }
        }

        public DeckView()
        {
            InitializeComponent();
            RenderView();
        }

        private void DeckView_Click(object sender, EventArgs e)
        {
            DeckClicked?.Invoke();
        }

        public void RenderView()
        {
            countLabel.Text = Deck != null ? Deck.Count.ToString() : string.Empty;
        }
    }
}
