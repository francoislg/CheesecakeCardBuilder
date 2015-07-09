namespace CheesecakeCardBuilder.Builders.Description {
    partial class DefaultDescriptionControl {
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
            this.whenBox = new System.Windows.Forms.TextBox();
            this.targetBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.actionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "When";
            // 
            // whenBox
            // 
            this.whenBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.whenBox.Location = new System.Drawing.Point(46, 1);
            this.whenBox.Name = "whenBox";
            this.whenBox.Size = new System.Drawing.Size(350, 20);
            this.whenBox.TabIndex = 1;
            this.whenBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.actionBox_KeyUp);
            // 
            // targetBox
            // 
            this.targetBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.targetBox.Location = new System.Drawing.Point(46, 27);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(350, 20);
            this.targetBox.TabIndex = 3;
            this.targetBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.actionBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Action";
            // 
            // actionBox
            // 
            this.actionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.actionBox.Location = new System.Drawing.Point(46, 53);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(350, 20);
            this.actionBox.TabIndex = 5;
            this.actionBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.actionBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Target";
            // 
            // DefaultUnitDescriptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.actionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.targetBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.whenBox);
            this.Controls.Add(this.label1);
            this.Name = "DefaultUnitDescriptionControl";
            this.Size = new System.Drawing.Size(400, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox whenBox;
        private System.Windows.Forms.TextBox targetBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox actionBox;
        private System.Windows.Forms.Label label3;
    }
}
