﻿namespace CheesecakeCardBuilder.Unit {
    partial class CardLoader {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardLoader));
            this.cardsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cardsListBox
            // 
            this.cardsListBox.FormattingEnabled = true;
            this.cardsListBox.Location = new System.Drawing.Point(13, 13);
            this.cardsListBox.Name = "cardsListBox";
            this.cardsListBox.Size = new System.Drawing.Size(414, 225);
            this.cardsListBox.TabIndex = 0;
            this.cardsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cardsListBox_MouseDoubleClick);
            // 
            // CardLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 246);
            this.Controls.Add(this.cardsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardLoader";
            this.Text = "CardLoader";
            this.Load += new System.EventHandler(this.CardLoader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cardsListBox;

    }
}