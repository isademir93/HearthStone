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
            this.playerView1 = new HearthStone.UI.PlayerView();
            this.playerView2 = new HearthStone.UI.PlayerView();
            this.endTurnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerView1
            // 
            this.playerView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerView1.Location = new System.Drawing.Point(3, 3);
            this.playerView1.Name = "playerView1";
            this.playerView1.Player = null;
            this.playerView1.Size = new System.Drawing.Size(250, 350);
            this.playerView1.TabIndex = 0;
            this.playerView1.ViewType = HearthStone.UI.PlayerViewType.Left;
            // 
            // playerView2
            // 
            this.playerView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerView2.Location = new System.Drawing.Point(259, 3);
            this.playerView2.Name = "playerView2";
            this.playerView2.Player = null;
            this.playerView2.Size = new System.Drawing.Size(250, 350);
            this.playerView2.TabIndex = 1;
            this.playerView2.ViewType = HearthStone.UI.PlayerViewType.Right;
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
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.endTurnButton);
            this.Controls.Add(this.playerView2);
            this.Controls.Add(this.playerView1);
            this.Name = "GamePanel";
            this.Size = new System.Drawing.Size(512, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private PlayerView playerView1;
        private PlayerView playerView2;
        private System.Windows.Forms.Button endTurnButton;
    }
}
