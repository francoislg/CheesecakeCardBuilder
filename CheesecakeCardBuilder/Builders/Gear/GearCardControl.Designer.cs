namespace CheesecakeCardBuilder.Builders.Gear {
    partial class GearCardControl {
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
            this.descriptionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.atkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.defTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rareCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // descriptionsPanel
            // 
            this.descriptionsPanel.Location = new System.Drawing.Point(6, 108);
            this.descriptionsPanel.Name = "descriptionsPanel";
            this.descriptionsPanel.Size = new System.Drawing.Size(511, 219);
            this.descriptionsPanel.TabIndex = 43;
            // 
            // atkTextBox
            // 
            this.atkTextBox.Location = new System.Drawing.Point(53, 13);
            this.atkTextBox.Name = "atkTextBox";
            this.atkTextBox.Size = new System.Drawing.Size(28, 20);
            this.atkTextBox.TabIndex = 44;
            this.atkTextBox.TextChanged += new System.EventHandler(this.resTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Atk";
            // 
            // defTextBox
            // 
            this.defTextBox.Location = new System.Drawing.Point(53, 39);
            this.defTextBox.Name = "defTextBox";
            this.defTextBox.Size = new System.Drawing.Size(28, 20);
            this.defTextBox.TabIndex = 46;
            this.defTextBox.TextChanged += new System.EventHandler(this.resTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Def";
            // 
            // resTextBox
            // 
            this.resTextBox.Location = new System.Drawing.Point(190, 13);
            this.resTextBox.Name = "resTextBox";
            this.resTextBox.Size = new System.Drawing.Size(28, 20);
            this.resTextBox.TabIndex = 48;
            this.resTextBox.TextChanged += new System.EventHandler(this.resTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Res";
            // 
            // rareCheckbox
            // 
            this.rareCheckbox.AutoSize = true;
            this.rareCheckbox.Location = new System.Drawing.Point(468, 85);
            this.rareCheckbox.Name = "rareCheckbox";
            this.rareCheckbox.Size = new System.Drawing.Size(49, 17);
            this.rareCheckbox.TabIndex = 50;
            this.rareCheckbox.Text = "Rare";
            this.rareCheckbox.UseVisualStyleBackColor = true;
            this.rareCheckbox.CheckedChanged += new System.EventHandler(this.resTextBox_TextChanged);
            // 
            // GearCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rareCheckbox);
            this.Controls.Add(this.resTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.defTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.atkTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionsPanel);
            this.Name = "GearCardControl";
            this.Size = new System.Drawing.Size(520, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel descriptionsPanel;
        private System.Windows.Forms.TextBox atkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox defTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox rareCheckbox;
    }
}
