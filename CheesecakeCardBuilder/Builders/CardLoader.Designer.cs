namespace CheesecakeCardBuilder.Builders {
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
            this.loadTabs = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadTabs
            // 
            this.loadTabs.Location = new System.Drawing.Point(12, 12);
            this.loadTabs.Name = "loadTabs";
            this.loadTabs.SelectedIndex = 0;
            this.loadTabs.Size = new System.Drawing.Size(370, 253);
            this.loadTabs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Double-click to load a card";
            // 
            // CardLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardLoader";
            this.Text = "CardLoader";
            this.Load += new System.EventHandler(this.CardLoader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl loadTabs;
        private System.Windows.Forms.Label label1;


    }
}