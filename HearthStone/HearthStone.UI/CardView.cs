using HearthStoneLib;
using System.Windows.Forms;

namespace HearthStone.UI
{
    public delegate void CardClickedEventHandler(int cardIndex);

    public partial class CardView : UserControl
    {
        private IHand hand;

        public IHand Hand
        {
            get => hand;
            set
            {
                hand = value;

                RenderView();
            }
        }

        public int CardIndex { get; set; }

        public event CardClickedEventHandler CardClicked;

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

        private void CardView_Click(object sender, System.EventArgs e)
        {
            CardClicked?.Invoke(CardIndex);
        }
    }
}
