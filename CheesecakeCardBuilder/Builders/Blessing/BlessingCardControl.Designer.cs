namespace CheesecakeCardBuilder.Builders.Blessing {
    partial class BlessingCardControl {
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
            this.label3 = new System.Windows.Forms.Label();
            this.resTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // descriptionsPanel
            // 
            this.descriptionsPanel.Location = new System.Drawing.Point(6, 108);
            this.descriptionsPanel.Name = "descriptionsPanel";
            this.descriptionsPanel.Size = new System.Drawing.Size(511, 219);
            this.descriptionsPanel.TabIndex = 43;
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
            // resTextBox
            // 
            this.resTextBox.Location = new System.Drawing.Point(190, 13);
            this.resTextBox.Name = "resTextBox";
            this.resTextBox.Size = new System.Drawing.Size(28, 20);
            this.resTextBox.TabIndex = 48;
            this.resTextBox.TextChanged += new System.EventHandler(this.resTextBox_TextChanged);
            // 
            // BlessingCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descriptionsPanel);
            this.Name = "BlessingCardControl";
            this.Size = new System.Drawing.Size(520, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel descriptionsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resTextBox;
    }
}
