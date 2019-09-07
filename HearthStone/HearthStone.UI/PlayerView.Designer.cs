namespace HearthStone.UI
{
    partial class PlayerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerView));
            this.deck = new HearthStone.UI.DeckView();
            this.cardView1 = new HearthStone.UI.CardView();
            this.cardView2 = new HearthStone.UI.CardView();
            this.cardView3 = new HearthStone.UI.CardView();
            this.cardView4 = new HearthStone.UI.CardView();
            this.cardView5 = new HearthStone.UI.CardView();
            this.healtLabel = new System.Windows.Forms.Label();
            this.manaLabel = new System.Windows.Forms.Label();
            this.manaValueLabel = new System.Windows.Forms.Label();
            this.healthValueLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.cardPanel = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            this.cardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deck
            // 
            this.deck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deck.BackgroundImage")));
            this.deck.Location = new System.Drawing.Point(3, 283);
            this.deck.Name = "deck";
            this.deck.Size = new System.Drawing.Size(43, 64);
            this.deck.TabIndex = 0;
            // 
            // cardView1
            // 
            this.cardView1.BackColor = System.Drawing.SystemColors.Control;
            this.cardView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardView1.CardIndex = 0;
            this.cardView1.Location = new System.Drawing.Point(4, 3);
            this.cardView1.Name = "cardView1";
            this.cardView1.Size = new System.Drawing.Size(43, 64);
            this.cardView1.TabIndex = 1;
            // 
            // cardView2
            // 
            this.cardView2.BackColor = System.Drawing.SystemColors.Control;
            this.cardView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardView2.CardIndex = 0;
            this.cardView2.Location = new System.Drawing.Point(4, 73);
            this.cardView2.Name = "cardView2";
            this.cardView2.Size = new System.Drawing.Size(43, 64);
            this.cardView2.TabIndex = 2;
            // 
            // cardView3
            // 
            this.cardView3.BackColor = System.Drawing.SystemColors.Control;
            this.cardView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardView3.CardIndex = 0;
            this.cardView3.Location = new System.Drawing.Point(4, 143);
            this.cardView3.Name = "cardView3";
            this.cardView3.Size = new System.Drawing.Size(43, 64);
            this.cardView3.TabIndex = 4;
            // 
            // cardView4
            // 
            this.cardView4.BackColor = System.Drawing.SystemColors.Control;
            this.cardView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardView4.CardIndex = 0;
            this.cardView4.Location = new System.Drawing.Point(4, 213);
            this.cardView4.Name = "cardView4";
            this.cardView4.Size = new System.Drawing.Size(43, 64);
            this.cardView4.TabIndex = 3;
            // 
            // cardView5
            // 
            this.cardView5.BackColor = System.Drawing.SystemColors.Control;
            this.cardView5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardView5.CardIndex = 0;
            this.cardView5.Location = new System.Drawing.Point(4, 283);
            this.cardView5.Name = "cardView5";
            this.cardView5.Size = new System.Drawing.Size(43, 64);
            this.cardView5.TabIndex = 5;
            // 
            // healtLabel
            // 
            this.healtLabel.AutoSize = true;
            this.healtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.healtLabel.Location = new System.Drawing.Point(3, 3);
            this.healtLabel.Name = "healtLabel";
            this.healtLabel.Size = new System.Drawing.Size(80, 25);
            this.healtLabel.TabIndex = 6;
            this.healtLabel.Text = "Health";
            // 
            // manaLabel
            // 
            this.manaLabel.AutoSize = true;
            this.manaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manaLabel.Location = new System.Drawing.Point(3, 32);
            this.manaLabel.Name = "manaLabel";
            this.manaLabel.Size = new System.Drawing.Size(70, 25);
            this.manaLabel.TabIndex = 7;
            this.manaLabel.Text = "Mana";
            // 
            // manaValueLabel
            // 
            this.manaValueLabel.AutoSize = true;
            this.manaValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manaValueLabel.ForeColor = System.Drawing.Color.Blue;
            this.manaValueLabel.Location = new System.Drawing.Point(79, 32);
            this.manaValueLabel.Name = "manaValueLabel";
            this.manaValueLabel.Size = new System.Drawing.Size(25, 25);
            this.manaValueLabel.TabIndex = 9;
            this.manaValueLabel.Text = "0";
            // 
            // healthValueLabel
            // 
            this.healthValueLabel.AutoSize = true;
            this.healthValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.healthValueLabel.ForeColor = System.Drawing.Color.Red;
            this.healthValueLabel.Location = new System.Drawing.Point(79, 3);
            this.healthValueLabel.Name = "healthValueLabel";
            this.healthValueLabel.Size = new System.Drawing.Size(38, 25);
            this.healthValueLabel.TabIndex = 8;
            this.healthValueLabel.Text = "30";
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.healtLabel);
            this.infoPanel.Controls.Add(this.manaValueLabel);
            this.infoPanel.Controls.Add(this.manaLabel);
            this.infoPanel.Controls.Add(this.healthValueLabel);
            this.infoPanel.Location = new System.Drawing.Point(3, 3);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(120, 60);
            this.infoPanel.TabIndex = 10;
            // 
            // cardPanel
            // 
            this.cardPanel.Controls.Add(this.cardView1);
            this.cardPanel.Controls.Add(this.cardView2);
            this.cardPanel.Controls.Add(this.cardView5);
            this.cardPanel.Controls.Add(this.cardView4);
            this.cardPanel.Controls.Add(this.cardView3);
            this.cardPanel.Location = new System.Drawing.Point(200, 0);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(50, 350);
            this.cardPanel.TabIndex = 11;
            // 
            // PlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cardPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.deck);
            this.Location = new System.Drawing.Point(3, 0);
            this.Name = "PlayerView";
            this.Size = new System.Drawing.Size(248, 348);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.cardPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DeckView deck;
        private CardView cardView1;
        private CardView cardView2;
        private CardView cardView3;
        private CardView cardView4;
        private CardView cardView5;
        private System.Windows.Forms.Label healtLabel;
        private System.Windows.Forms.Label manaLabel;
        private System.Windows.Forms.Label manaValueLabel;
        private System.Windows.Forms.Label healthValueLabel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel cardPanel;
    }
}
