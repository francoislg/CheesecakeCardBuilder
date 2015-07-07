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
            this.unitListBox = new System.Windows.Forms.ListBox();
            this.unitSearchBox = new System.Windows.Forms.TextBox();
            this.loadTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.structureSearchBox = new System.Windows.Forms.TextBox();
            this.structureListBox = new System.Windows.Forms.ListBox();
            this.loadTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // unitListBox
            // 
            this.unitListBox.FormattingEnabled = true;
            this.unitListBox.Location = new System.Drawing.Point(6, 35);
            this.unitListBox.Name = "unitListBox";
            this.unitListBox.Size = new System.Drawing.Size(346, 186);
            this.unitListBox.TabIndex = 0;
            this.unitListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cardsListBox_MouseDoubleClick);
            // 
            // unitSearchBox
            // 
            this.unitSearchBox.Location = new System.Drawing.Point(6, 9);
            this.unitSearchBox.Name = "unitSearchBox";
            this.unitSearchBox.Size = new System.Drawing.Size(346, 20);
            this.unitSearchBox.TabIndex = 1;
            this.unitSearchBox.TextChanged += new System.EventHandler(this.unitSearchBox_TextChanged);
            // 
            // loadTab
            // 
            this.loadTab.Controls.Add(this.tabPage1);
            this.loadTab.Controls.Add(this.tabPage2);
            this.loadTab.Location = new System.Drawing.Point(12, 12);
            this.loadTab.Name = "loadTab";
            this.loadTab.SelectedIndex = 0;
            this.loadTab.Size = new System.Drawing.Size(370, 253);
            this.loadTab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.unitSearchBox);
            this.tabPage1.Controls.Add(this.unitListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(362, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Units";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.structureSearchBox);
            this.tabPage2.Controls.Add(this.structureListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(362, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Structures";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // structureSearchBox
            // 
            this.structureSearchBox.Location = new System.Drawing.Point(6, 9);
            this.structureSearchBox.Name = "structureSearchBox";
            this.structureSearchBox.Size = new System.Drawing.Size(346, 20);
            this.structureSearchBox.TabIndex = 3;
            this.structureSearchBox.TextChanged += new System.EventHandler(this.structureSearchbox_TextChanged);
            // 
            // structureListBox
            // 
            this.structureListBox.FormattingEnabled = true;
            this.structureListBox.Location = new System.Drawing.Point(6, 35);
            this.structureListBox.Name = "structureListBox";
            this.structureListBox.Size = new System.Drawing.Size(346, 186);
            this.structureListBox.TabIndex = 2;
            this.structureListBox.DoubleClick += new System.EventHandler(this.structureListbox_DoubleClick);
            // 
            // CardLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 270);
            this.Controls.Add(this.loadTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardLoader";
            this.Text = "CardLoader";
            this.Load += new System.EventHandler(this.CardLoader_Load);
            this.loadTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox unitListBox;
        private System.Windows.Forms.TextBox unitSearchBox;
        private System.Windows.Forms.TabControl loadTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox structureSearchBox;
        private System.Windows.Forms.ListBox structureListBox;

    }
}