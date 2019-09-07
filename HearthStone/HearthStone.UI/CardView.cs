using HearthStoneLib;
using System.Windows.Forms;

namespace HearthStone.UI
{
    public partial class CardView : UserControl
    {
        private IHand hand;

        public int CardIndex { get; set; }

        public CardView()
        {
            InitializeComponent();
            RenderView();
        }

        public CardView(IHand hand, int cardIndex) : this()
        {
            Hand = hand;
            CardIndex = cardIndex;
        }

        public IHand Hand
        {
            get => hand;
            private set
            {
                hand = value;

                RenderView();
            }
        }

        public void RenderView()
        {
            manaCostLabel.Text = string.Empty;
            BackColor = System.Drawing.SystemColors.Control;

            if (hand != null)
            {
                var card = hand.Cards.Length > CardIndex ? hand.Cards[CardIndex] : null;

                if (card != null)
                {
                    manaCostLabel.Text = card.ManaCost.ToString();
                    BackColor = System.Drawing.SystemColors.ActiveCaption;
                }
            }
        }
    }
}
