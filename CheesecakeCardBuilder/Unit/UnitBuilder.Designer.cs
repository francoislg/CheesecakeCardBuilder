namespace CheesecakeCardBuilder {
    partial class UnitBuilder {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitBuilder));
            this.atkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.defTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.spdTextbox = new System.Windows.Forms.TextBox();
            this.resTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hpTextbox = new System.Windows.Forms.TextBox();
            this.descriptionComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.previewPicture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionPanel2 = new System.Windows.Forms.Panel();
            this.descriptionComboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.exportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // atkTextBox
            // 
            this.atkTextBox.Location = new System.Drawing.Point(50, 45);
            this.atkTextBox.Name = "atkTextBox";
            this.atkTextBox.Size = new System.Drawing.Size(28, 20);
            this.atkTextBox.TabIndex = 2;
            this.atkTextBox.TextChanged += new System.EventHandler(this.event_UpdatePicture);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Def";
            // 
            // defTextBox
            // 
            this.defTextBox.Location = new System.Drawing.Point(50, 71);
            this.defTextBox.Name = "defTextBox";
            this.defTextBox.Size = new System.Drawing.Size(28, 20);
            this.defTextBox.TabIndex = 4;
            this.defTextBox.TextChanged += new System.EventHandler(this.event_UpdatePicture);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Acc";
            // 
            // accTextBox
            // 
            this.accTextBox.Location = new System.Drawing.Point(127, 71);
            this.accTextBox.Name = "accTextBox";
            this.accTextBox.Size = new System.Drawing.Size(28, 20);
            this.accTextBox.TabIndex = 5;
            this.accTextBox.TextChanged += new System.EventHandler(this.event_UpdatePicture);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Spd";
            // 
            // spdTextbox
            // 
            this.spdTextbox.Location = new System.Drawing.Point(127, 45);
            this.spdTextbox.Name = "spdTextbox";
            this.spdTextbox.Size = new System.Drawing.Size(28, 20);
            this.spdTextbox.TabIndex = 3;
            this.spdTextbox.TextChanged += new System.EventHandler(this.event_UpdatePicture);
            // 
            // resTextbox
            // 
            this.resTextbox.Location = new System.Drawing.Point(127, 12);
            this.resTextbox.Name = "resTextbox";
            this.resTextbox.Size = new System.Drawing.Size(28, 20);
            this.resTextbox.TabIndex = 1;
            this.resTextbox.TextChanged += new System.EventHandler(this.event_UpdatePicture);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Res";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "HP";
            // 
            // hpTextbox
            // 
            this.hpTextbox.Location = new System.Drawing.Point(50, 12);
            this.hpTextbox.Name = "hpTextbox";
            this.hpTextbox.Size = new System.Drawing.Size(28, 20);
            this.hpTextbox.TabIndex = 0;
            this.hpTextbox.TextChanged += new System.EventHandler(this.event_UpdatePicture);
            // 
            // descriptionComboBox
            // 
            this.descriptionComboBox.FormattingEnabled = true;
            this.descriptionComboBox.Location = new System.Drawing.Point(12, 97);
            this.descriptionComboBox.Name = "descriptionComboBox";
            this.descriptionComboBox.Size = new System.Drawing.Size(143, 21);
            this.descriptionComboBox.TabIndex = 7;
            this.descriptionComboBox.SelectedIndexChanged += new System.EventHandler(this.descriptionComboBox_SelectedIndexChanged);
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Location = new System.Drawing.Point(12, 125);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(400, 80);
            this.descriptionPanel.TabIndex = 13;
            // 
            // previewPicture
            // 
            this.previewPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.previewPicture.InitialImage = null;
            this.previewPicture.Location = new System.Drawing.Point(428, 11);
            this.previewPicture.Name = "previewPicture";
            this.previewPicture.Size = new System.Drawing.Size(263, 363);
            this.previewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPicture.TabIndex = 14;
            this.previewPicture.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(177, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(235, 20);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.event_UpdatePicture);
            // 
            // descriptionPanel2
            // 
            this.descriptionPanel2.Location = new System.Drawing.Point(12, 239);
            this.descriptionPanel2.Name = "descriptionPanel2";
            this.descriptionPanel2.Size = new System.Drawing.Size(400, 80);
            this.descriptionPanel2.TabIndex = 17;
            // 
            // descriptionComboBox2
            // 
            this.descriptionComboBox2.FormattingEnabled = true;
            this.descriptionComboBox2.Location = new System.Drawing.Point(12, 211);
            this.descriptionComboBox2.Name = "descriptionComboBox2";
            this.descriptionComboBox2.Size = new System.Drawing.Size(143, 21);
            this.descriptionComboBox2.TabIndex = 16;
            this.descriptionComboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(177, 74);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(235, 21);
            this.typeComboBox.TabIndex = 19;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(337, 350);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 20;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // UnitBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 385);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descriptionPanel2);
            this.Controls.Add(this.descriptionComboBox2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.previewPicture);
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.descriptionComboBox);
            this.Controls.Add(this.resTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hpTextbox);
            this.Controls.Add(this.spdTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.defTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atkTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(719, 424);
            this.Name = "UnitBuilder";
            this.Text = "Unit Builder";
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox atkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox defTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox spdTextbox;
        private System.Windows.Forms.TextBox resTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hpTextbox;
        private System.Windows.Forms.ComboBox descriptionComboBox;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.PictureBox previewPicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Panel descriptionPanel2;
        private System.Windows.Forms.ComboBox descriptionComboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.SaveFileDialog exportSaveFileDialog;
    }
}

