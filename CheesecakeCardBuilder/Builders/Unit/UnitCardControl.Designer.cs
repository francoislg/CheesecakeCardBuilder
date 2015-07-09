namespace CheesecakeCardBuilder.Builders.Unit {
    partial class UnitCardControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hpTextbox = new System.Windows.Forms.TextBox();
            this.spdTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.defTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.atkTextBox = new System.Windows.Forms.TextBox();
            this.descriptionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(259, 27);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(235, 21);
            this.typeComboBox.TabIndex = 39;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Unit Type";
            // 
            // resTextbox
            // 
            this.resTextbox.Location = new System.Drawing.Point(127, 13);
            this.resTextbox.Name = "resTextbox";
            this.resTextbox.Size = new System.Drawing.Size(28, 20);
            this.resTextbox.TabIndex = 21;
            this.resTextbox.TextChanged += new System.EventHandler(this.hpTextbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Res";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "HP";
            // 
            // hpTextbox
            // 
            this.hpTextbox.Location = new System.Drawing.Point(50, 13);
            this.hpTextbox.Name = "hpTextbox";
            this.hpTextbox.Size = new System.Drawing.Size(28, 20);
            this.hpTextbox.TabIndex = 20;
            this.hpTextbox.TextChanged += new System.EventHandler(this.hpTextbox_TextChanged);
            // 
            // spdTextbox
            // 
            this.spdTextbox.Location = new System.Drawing.Point(127, 46);
            this.spdTextbox.Name = "spdTextbox";
            this.spdTextbox.Size = new System.Drawing.Size(28, 20);
            this.spdTextbox.TabIndex = 25;
            this.spdTextbox.TextChanged += new System.EventHandler(this.hpTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Spd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Acc";
            // 
            // accTextBox
            // 
            this.accTextBox.Location = new System.Drawing.Point(127, 72);
            this.accTextBox.Name = "accTextBox";
            this.accTextBox.Size = new System.Drawing.Size(28, 20);
            this.accTextBox.TabIndex = 27;
            this.accTextBox.TextChanged += new System.EventHandler(this.hpTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Def";
            // 
            // defTextBox
            // 
            this.defTextBox.Location = new System.Drawing.Point(50, 72);
            this.defTextBox.Name = "defTextBox";
            this.defTextBox.Size = new System.Drawing.Size(28, 20);
            this.defTextBox.TabIndex = 26;
            this.defTextBox.TextChanged += new System.EventHandler(this.hpTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Atk";
            // 
            // atkTextBox
            // 
            this.atkTextBox.Location = new System.Drawing.Point(50, 46);
            this.atkTextBox.Name = "atkTextBox";
            this.atkTextBox.Size = new System.Drawing.Size(28, 20);
            this.atkTextBox.TabIndex = 23;
            this.atkTextBox.TextChanged += new System.EventHandler(this.hpTextbox_TextChanged);
            // 
            // descriptionsPanel
            // 
            this.descriptionsPanel.AutoScroll = true;
            this.descriptionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.descriptionsPanel.Location = new System.Drawing.Point(4, 98);
            this.descriptionsPanel.Name = "descriptionsPanel";
            this.descriptionsPanel.Size = new System.Drawing.Size(515, 230);
            this.descriptionsPanel.TabIndex = 40;
            this.descriptionsPanel.WrapContents = false;
            // 
            // UnitCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descriptionsPanel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label8);
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
            this.Name = "UnitCardControl";
            this.Size = new System.Drawing.Size(520, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox resTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hpTextbox;
        private System.Windows.Forms.TextBox spdTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox defTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox atkTextBox;
        private System.Windows.Forms.FlowLayoutPanel descriptionsPanel;
    }
}
