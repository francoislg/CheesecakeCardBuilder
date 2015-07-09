namespace CheesecakeCardBuilder.Builders.Caster {
    partial class CasterCardControl {
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
            this.resTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resTextbox
            // 
            this.resTextbox.Location = new System.Drawing.Point(191, 21);
            this.resTextbox.Name = "resTextbox";
            this.resTextbox.Size = new System.Drawing.Size(28, 20);
            this.resTextbox.TabIndex = 36;
            this.resTextbox.TextChanged += new System.EventHandler(this.resTextbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Res";
            // 
            // CasterCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resTextbox);
            this.Controls.Add(this.label5);
            this.Name = "CasterCardControl";
            this.Size = new System.Drawing.Size(520, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resTextbox;
        private System.Windows.Forms.Label label5;
    }
}
