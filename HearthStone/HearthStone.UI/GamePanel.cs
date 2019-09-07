using HearthStoneLib;
using System.Text;
using System.Windows.Forms;

namespace HearthStone.UI
{
    public partial class GamePanel : UserControl
    {
        IHearthStoneGame Game { get; set; }

        public GamePanel()
        {
            InitializeComponent();

            Game = HearthStoneGame.CreateGame();

            Game.GameOvered += Game_GameOvered;

            playerA.Player = Game.PlayerA;
            playerB.Player = Game.PlayerB;

            RenderView();
        }

        private void Game_GameOvered(IPlayer winner)
        {
            Enabled = false;

            var message = new StringBuilder();
            var playerName = winner == playerA.Player ? "Soldaki" : "Sağdaki";
            message.AppendLine("Oyun Bitti!");
            message.AppendLine($"Kazanan: {playerName} Oyuncu");

            MessageBox.Show(message.ToString(), "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void RenderView()
        {
            playerA.Enabled = Game.IsFirstPlayerActive;
            playerB.Enabled = !Game.IsFirstPlayerActive;

            playerA.RenderView();
            playerB.RenderView();

            if (Game.GameOver)
            {
                Enabled = false;
            }
        }

        private void player_DeckClicked(IPlayer player)
        {
            var activePlayer = Game.ActivePlayer;

            if (player == activePlayer)
            {
                var result = Game.AcquireCardFromDeck();


                string message = string.Empty;
                switch (result)
                {
                    case AcquiredCardFromDeckResult.GameOver:
                        //message = "Oyun bitti";
                        break;
                    case AcquiredCardFromDeckResult.AlreadyAquired:
                        message = "Daha önce kart çekmiştiniz!";
                        break;
                    case AcquiredCardFromDeckResult.HandIsFull:
                        message = "Bir kart çektiniz ancak eliniz dolu olduğundan, kart sonsuzluğa doğru kayboldu!";
                        break;
                    case AcquiredCardFromDeckResult.DeckIsEmpty:
                        message = "Malesef kartlar suyunu çekti";
                        break;
                    case AcquiredCardFromDeckResult.Success:
                        break;
                    default:
                        break;
                }

                RenderView();

                if (!string.IsNullOrWhiteSpace(message))
                {
                    MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void player_CardClicked(IPlayer player, int cardIndex)
        {
            var activePlayer = Game.ActivePlayer;

            if (player == activePlayer)
            {
                var result = Game.Attack(cardIndex);
                string message = string.Empty;
                switch (result)
                {
                    case AttackResult.GameOver:
                        break;
                    case AttackResult.NotAcquiredCardFromDeck:
                        message = "Saldırmadan önce bir kart çekiniz";
                        break;
                    case AttackResult.InvalidCardIndex:
                        message = "Var olan kartlarımızdan birini seçiniz";
                        break;
                    case AttackResult.InsufficientMana:
                        message = "Bu kartla saldırmak için yeterli mananız yok";
                        break;
                    case AttackResult.Success:
                        break;
                    case AttackResult.SuccessGameEnd:
                        break;
                    default:
                        break;
                }

                RenderView();

                if (!string.IsNullOrWhiteSpace(message))
                {
                    MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void endTurnButton_Click(object sender, System.EventArgs e)
        {
            Game.EndPlayerTurn();

            RenderView();
        }

        public void ShowGameInfo()
        {
            var message = new StringBuilder();
            message.AppendLine("Hearth Stone Oyununa Hoşgeldiniz!");
            message.AppendLine("Oyun sırasında kart çekmek için ya da saldırmak için kartların üzerine tıklayınız!");
            message.AppendLine();
            message.AppendLine("İyi oynayan kazansın :)");
            MessageBox.Show(message.ToString(), "Oyun Bilgi");
        }
    }
}
