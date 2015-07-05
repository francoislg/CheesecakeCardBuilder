namespace CheesecakeCardBuilder.Builder.Unit {
    partial class KeywordUnitDescriptionControl {
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
            this.label1 = new System.Windows.Forms.Label();
            this.keywordComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keyword";
            // 
            // keywordComboBox
            // 
            this.keywordComboBox.FormattingEnabled = true;
            this.keywordComboBox.Location = new System.Drawing.Point(4, 20);
            this.keywordComboBox.Name = "keywordComboBox";
            this.keywordComboBox.Size = new System.Drawing.Size(393, 21);
            this.keywordComboBox.TabIndex = 1;
            this.keywordComboBox.SelectedIndexChanged += new System.EventHandler(this.keywordComboBox_SelectedIndexChanged);
            // 
            // KeywordUnitDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.keywordComboBox);
            this.Controls.Add(this.label1);
            this.Name = "KeywordUnitDescription";
            this.Size = new System.Drawing.Size(400, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox keywordComboBox;

    }
}
