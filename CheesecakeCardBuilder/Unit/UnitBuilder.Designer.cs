﻿namespace CheesecakeCardBuilder {
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
            this.SuspendLayout();
            // 
            // atkTextBox
            // 
            this.atkTextBox.Location = new System.Drawing.Point(50, 45);
            this.atkTextBox.Name = "atkTextBox";
            this.atkTextBox.Size = new System.Drawing.Size(28, 20);
            this.atkTextBox.TabIndex = 0;
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
            this.defTextBox.TabIndex = 2;
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
            this.accTextBox.TabIndex = 4;
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
            this.spdTextbox.TabIndex = 7;
            // 
            // resTextbox
            // 
            this.resTextbox.Location = new System.Drawing.Point(127, 12);
            this.resTextbox.Name = "resTextbox";
            this.resTextbox.Size = new System.Drawing.Size(28, 20);
            this.resTextbox.TabIndex = 11;
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
            this.hpTextbox.TabIndex = 8;
            // 
            // descriptionComboBox
            // 
            this.descriptionComboBox.FormattingEnabled = true;
            this.descriptionComboBox.Location = new System.Drawing.Point(12, 97);
            this.descriptionComboBox.Name = "descriptionComboBox";
            this.descriptionComboBox.Size = new System.Drawing.Size(143, 21);
            this.descriptionComboBox.TabIndex = 12;
            this.descriptionComboBox.SelectedIndexChanged += new System.EventHandler(this.descriptionComboBox_SelectedIndexChanged);
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Location = new System.Drawing.Point(12, 125);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(592, 91);
            this.descriptionPanel.TabIndex = 13;
            // 
            // UnitBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 228);
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
            this.Name = "UnitBuilder";
            this.Text = "Unit Builder";
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
    }
}

