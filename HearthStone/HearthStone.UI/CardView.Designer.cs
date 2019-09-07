namespace HearthStone.UI
{
    partial class CardView
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
            this.manaCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manaCostLabel
            // 
            this.manaCostLabel.AutoSize = true;
            this.manaCostLabel.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaCostLabel.ForeColor = System.Drawing.Color.Red;
            this.manaCostLabel.Location = new System.Drawing.Point(5, 15);
            this.manaCostLabel.Name = "manaCostLabel";
            this.manaCostLabel.Size = new System.Drawing.Size(33, 32);
            this.manaCostLabel.TabIndex = 0;
            this.manaCostLabel.Text = "3";
            // 
            // CardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.manaCostLabel);
            this.Name = "CardView";
            this.Size = new System.Drawing.Size(43, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label manaCostLabel;
    }
}
