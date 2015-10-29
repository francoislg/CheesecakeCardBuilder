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
            this.textboxTag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tagsListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // loadTabs
            // 
            this.loadTabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.loadTabs.Location = new System.Drawing.Point(0, 0);
            this.loadTabs.Name = "loadTabs";
            this.loadTabs.SelectedIndex = 0;
            this.loadTabs.Size = new System.Drawing.Size(356, 299);
            this.loadTabs.TabIndex = 2;
            this.loadTabs.SizeChanged += new System.EventHandler(this.loadTabs_SizeChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Double-click to load a card";
            // 
            // textboxTag
            // 
            this.textboxTag.Location = new System.Drawing.Point(363, 22);
            this.textboxTag.Name = "textboxTag";
            this.textboxTag.Size = new System.Drawing.Size(141, 20);
            this.textboxTag.TabIndex = 4;
            this.textboxTag.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxTag_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tags";
            // 
            // tagsListbox
            // 
            this.tagsListbox.FormattingEnabled = true;
            this.tagsListbox.Location = new System.Drawing.Point(365, 49);
            this.tagsListbox.Name = "tagsListbox";
            this.tagsListbox.Size = new System.Drawing.Size(139, 238);
            this.tagsListbox.TabIndex = 6;
            this.tagsListbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tagsListbox_KeyUp);
            // 
            // CardLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 299);
            this.Controls.Add(this.tagsListbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(405, 337);
            this.Name = "CardLoader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CardLoader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl loadTabs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox tagsListbox;
    }
}