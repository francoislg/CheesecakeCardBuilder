namespace CheesecakeCardBuilder.Builders.Structure {
    partial class StructureCardControl {
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
            this.label1 = new System.Windows.Forms.Label();
            this.resTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prodTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.storTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.storSpeedTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(286, 24);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 0;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // resTextbox
            // 
            this.resTextbox.Location = new System.Drawing.Point(190, 21);
            this.resTextbox.Name = "resTextbox";
            this.resTextbox.Size = new System.Drawing.Size(28, 20);
            this.resTextbox.TabIndex = 34;
            this.resTextbox.TextChanged += new System.EventHandler(this.resTextbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Res";
            // 
            // prodTextbox
            // 
            this.prodTextbox.Location = new System.Drawing.Point(87, 21);
            this.prodTextbox.Name = "prodTextbox";
            this.prodTextbox.Size = new System.Drawing.Size(28, 20);
            this.prodTextbox.TabIndex = 36;
            this.prodTextbox.TextChanged += new System.EventHandler(this.resTextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Prod";
            // 
            // storTextbox
            // 
            this.storTextbox.Location = new System.Drawing.Point(87, 56);
            this.storTextbox.Name = "storTextbox";
            this.storTextbox.Size = new System.Drawing.Size(28, 20);
            this.storTextbox.TabIndex = 38;
            this.storTextbox.TextChanged += new System.EventHandler(this.resTextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Storage";
            // 
            // storSpeedTextbox
            // 
            this.storSpeedTextbox.Location = new System.Drawing.Point(87, 82);
            this.storSpeedTextbox.Name = "storSpeedTextbox";
            this.storSpeedTextbox.Size = new System.Drawing.Size(28, 20);
            this.storSpeedTextbox.TabIndex = 40;
            this.storSpeedTextbox.TextChanged += new System.EventHandler(this.resTextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Storage Speed";
            // 
            // StructureCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.storSpeedTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.storTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prodTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeComboBox);
            this.Name = "StructureCardControl";
            this.Size = new System.Drawing.Size(425, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prodTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox storTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox storSpeedTextbox;
        private System.Windows.Forms.Label label4;

    }
}
