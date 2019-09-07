namespace HearthStone.UI
{
    partial class GamePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.endTurnButton = new System.Windows.Forms.Button();
            this.playerB = new HearthStone.UI.PlayerView();
            this.playerA = new HearthStone.UI.PlayerView();
            this.SuspendLayout();
            // 
            // endTurnButton
            // 
            this.endTurnButton.BackColor = System.Drawing.Color.Green;
            this.endTurnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endTurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.endTurnButton.ForeColor = System.Drawing.Color.White;
            this.endTurnButton.Location = new System.Drawing.Point(166, 359);
            this.endTurnButton.Name = "endTurnButton";
            this.endTurnButton.Size = new System.Drawing.Size(176, 35);
            this.endTurnButton.TabIndex = 2;
            this.endTurnButton.Text = "End Turn";
            this.endTurnButton.UseVisualStyleBackColor = false;
            this.endTurnButton.Click += new System.EventHandler(this.endTurnButton_Click);
            // 
            // playerB
            // 
            this.playerB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerB.Location = new System.Drawing.Point(259, 3);
            this.playerB.Name = "playerB";
            this.playerB.Player = null;
            this.playerB.Size = new System.Drawing.Size(250, 350);
            this.playerB.TabIndex = 1;
            this.playerB.ViewType = HearthStone.UI.PlayerViewType.Right;
            this.playerB.CardClicked += new HearthStone.UI.PlayerCardClicked(this.player_CardClicked);
            this.playerB.DeckClicked += new HearthStone.UI.PlayerDeckClicked(this.player_DeckClicked);
            // 
            // playerA
            // 
            this.playerA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerA.Location = new System.Drawing.Point(3, 3);
            this.playerA.Name = "playerA";
            this.playerA.Player = null;
            this.playerA.Size = new System.Drawing.Size(250, 350);
            this.playerA.TabIndex = 0;
            this.playerA.ViewType = HearthStone.UI.PlayerViewType.Left;
            this.playerA.CardClicked += new HearthStone.UI.PlayerCardClicked(this.player_CardClicked);
            this.playerA.DeckClicked += new HearthStone.UI.PlayerDeckClicked(this.player_DeckClicked);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endTurnButton);
            this.Controls.Add(this.playerB);
            this.Controls.Add(this.playerA);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(512, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private PlayerView playerA;
        private PlayerView playerB;
        private System.Windows.Forms.Button endTurnButton;
    }
}
