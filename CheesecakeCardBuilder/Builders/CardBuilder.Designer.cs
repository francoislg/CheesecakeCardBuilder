namespace CheesecakeCardBuilder.Builders {
    partial class CardBuilder {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardBuilder));
            this.previewPicture = new System.Windows.Forms.PictureBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.exportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.artButton = new System.Windows.Forms.Button();
            this.artSelectionOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cardControlPanel = new System.Windows.Forms.Panel();
            this.tagTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tagsListbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // previewPicture
            // 
            this.previewPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.previewPicture.InitialImage = null;
            this.previewPicture.Location = new System.Drawing.Point(658, 12);
            this.previewPicture.Name = "previewPicture";
            this.previewPicture.Size = new System.Drawing.Size(289, 411);
            this.previewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPicture.TabIndex = 14;
            this.previewPicture.TabStop = false;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportButton.Location = new System.Drawing.Point(577, 399);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 20;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // exportSaveFileDialog
            // 
            this.exportSaveFileDialog.DefaultExt = "png";
            this.exportSaveFileDialog.FileName = "carte";
            this.exportSaveFileDialog.Filter = "Images|*.png";
            this.exportSaveFileDialog.Title = "Enregistrez votre carte";
            // 
            // artButton
            // 
            this.artButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.artButton.Location = new System.Drawing.Point(12, 399);
            this.artButton.Name = "artButton";
            this.artButton.Size = new System.Drawing.Size(75, 23);
            this.artButton.TabIndex = 21;
            this.artButton.Text = "Choose art";
            this.artButton.UseVisualStyleBackColor = true;
            this.artButton.Click += new System.EventHandler(this.artButton_Click);
            // 
            // artSelectionOpenFileDialog
            // 
            this.artSelectionOpenFileDialog.Filter = "396x276 image|*.png";
            this.artSelectionOpenFileDialog.Title = "Choisissez une image pour votre carte";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(496, 399);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadButton.Location = new System.Drawing.Point(415, 400);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 20;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(177, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(356, 20);
            this.nameTextBox.TabIndex = 36;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Name";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(12, 24);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(159, 21);
            this.typeComboBox.TabIndex = 38;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Type";
            // 
            // cardControlPanel
            // 
            this.cardControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cardControlPanel.Location = new System.Drawing.Point(13, 52);
            this.cardControlPanel.Name = "cardControlPanel";
            this.cardControlPanel.Size = new System.Drawing.Size(520, 330);
            this.cardControlPanel.TabIndex = 40;
            // 
            // tagTextbox
            // 
            this.tagTextbox.Location = new System.Drawing.Point(539, 25);
            this.tagTextbox.Name = "tagTextbox";
            this.tagTextbox.Size = new System.Drawing.Size(113, 20);
            this.tagTextbox.TabIndex = 41;
            this.tagTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tagTextbox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tags";
            // 
            // tagsListbox
            // 
            this.tagsListbox.FormattingEnabled = true;
            this.tagsListbox.Location = new System.Drawing.Point(540, 52);
            this.tagsListbox.Name = "tagsListbox";
            this.tagsListbox.Size = new System.Drawing.Size(112, 329);
            this.tagsListbox.TabIndex = 43;
            this.tagsListbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tagsListbox_KeyUp);
            // 
            // CardBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 435);
            this.Controls.Add(this.tagsListbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tagTextbox);
            this.Controls.Add(this.cardControlPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.artButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.previewPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(858, 473);
            this.Name = "CardBuilder";
            this.Text = "Card Builder";
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewPicture;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.SaveFileDialog exportSaveFileDialog;
        private System.Windows.Forms.Button artButton;
        private System.Windows.Forms.OpenFileDialog artSelectionOpenFileDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel cardControlPanel;
        private System.Windows.Forms.TextBox tagTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox tagsListbox;
    }
}

