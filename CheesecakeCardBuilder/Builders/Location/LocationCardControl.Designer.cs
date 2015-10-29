namespace CheesecakeCardBuilder.Builders.Location {
    partial class LocationCardControl {
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
            this.prodSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lifespanTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // prodSpeedTextBox
            // 
            this.prodSpeedTextBox.Location = new System.Drawing.Point(101, 21);
            this.prodSpeedTextBox.Name = "prodSpeedTextBox";
            this.prodSpeedTextBox.Size = new System.Drawing.Size(28, 20);
            this.prodSpeedTextBox.TabIndex = 44;
            this.prodSpeedTextBox.TextChanged += new System.EventHandler(this.lifespanTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Production Speed";
            // 
            // lifespanTextBox
            // 
            this.lifespanTextBox.Location = new System.Drawing.Point(101, 47);
            this.lifespanTextBox.Name = "lifespanTextBox";
            this.lifespanTextBox.Size = new System.Drawing.Size(28, 20);
            this.lifespanTextBox.TabIndex = 46;
            this.lifespanTextBox.TextChanged += new System.EventHandler(this.lifespanTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Lifespan";
            // 
            // rareCheckbox
            // 
            this.rareCheckbox.AutoSize = true;
            this.rareCheckbox.Location = new System.Drawing.Point(458, 73);
            this.rareCheckbox.Name = "rareCheckbox";
            this.rareCheckbox.Size = new System.Drawing.Size(49, 17);
            this.rareCheckbox.TabIndex = 48;
            this.rareCheckbox.Text = "Rare";
            this.rareCheckbox.UseVisualStyleBackColor = true;
            this.rareCheckbox.CheckedChanged += new System.EventHandler(this.lifespanTextBox_TextChanged);
            // 
            // LocationCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rareCheckbox);
            this.Controls.Add(this.lifespanTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prodSpeedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionsPanel);
            this.Name = "LocationCardControl";
            this.Size = new System.Drawing.Size(520, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel descriptionsPanel;
        private System.Windows.Forms.TextBox prodSpeedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lifespanTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rareCheckbox;
    }
}
