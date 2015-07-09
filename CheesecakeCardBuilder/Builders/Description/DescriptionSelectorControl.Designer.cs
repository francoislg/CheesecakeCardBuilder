namespace CheesecakeCardBuilder.Builders.Description {
    partial class DescriptionSelectorControl {
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
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.Location = new System.Drawing.Point(3, 31);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(400, 80);
            this.descriptionPanel.TabIndex = 36;
            // 
            // descriptionComboBox
            // 
            this.descriptionComboBox.FormattingEnabled = true;
            this.descriptionComboBox.Location = new System.Drawing.Point(3, 3);
            this.descriptionComboBox.Name = "descriptionComboBox";
            this.descriptionComboBox.Size = new System.Drawing.Size(143, 21);
            this.descriptionComboBox.TabIndex = 35;
            this.descriptionComboBox.SelectedIndexChanged += new System.EventHandler(this.descriptionComboBox_SelectedIndexChanged);
            // 
            // DescriptionSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descriptionPanel);
            this.Controls.Add(this.descriptionComboBox);
            this.Name = "DescriptionSelectorControl";
            this.Size = new System.Drawing.Size(407, 115);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.ComboBox descriptionComboBox;
    }
}
