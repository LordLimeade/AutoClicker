namespace Auto_Clicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UntilStoppedRadioBtn = new System.Windows.Forms.RadioButton();
            this.WhilePressedRadioBtn = new System.Windows.Forms.RadioButton();
            this.SetAmountRadioBtn = new System.Windows.Forms.RadioButton();
            this.LaunchBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetAmountRadioBtn);
            this.groupBox1.Controls.Add(this.WhilePressedRadioBtn);
            this.groupBox1.Controls.Add(this.UntilStoppedRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // UntilStoppedRadioBtn
            // 
            this.UntilStoppedRadioBtn.AutoSize = true;
            this.UntilStoppedRadioBtn.Location = new System.Drawing.Point(16, 26);
            this.UntilStoppedRadioBtn.Name = "UntilStoppedRadioBtn";
            this.UntilStoppedRadioBtn.Size = new System.Drawing.Size(131, 24);
            this.UntilStoppedRadioBtn.TabIndex = 0;
            this.UntilStoppedRadioBtn.TabStop = true;
            this.UntilStoppedRadioBtn.Text = "Until Stopped";
            this.UntilStoppedRadioBtn.UseVisualStyleBackColor = true;
            // 
            // WhilePressedRadioBtn
            // 
            this.WhilePressedRadioBtn.AutoSize = true;
            this.WhilePressedRadioBtn.Location = new System.Drawing.Point(16, 57);
            this.WhilePressedRadioBtn.Name = "WhilePressedRadioBtn";
            this.WhilePressedRadioBtn.Size = new System.Drawing.Size(135, 24);
            this.WhilePressedRadioBtn.TabIndex = 1;
            this.WhilePressedRadioBtn.TabStop = true;
            this.WhilePressedRadioBtn.Text = "While Pressed";
            this.WhilePressedRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SetAmountRadioBtn
            // 
            this.SetAmountRadioBtn.AutoSize = true;
            this.SetAmountRadioBtn.Location = new System.Drawing.Point(16, 88);
            this.SetAmountRadioBtn.Name = "SetAmountRadioBtn";
            this.SetAmountRadioBtn.Size = new System.Drawing.Size(119, 24);
            this.SetAmountRadioBtn.TabIndex = 2;
            this.SetAmountRadioBtn.TabStop = true;
            this.SetAmountRadioBtn.Text = "Set Amount";
            this.SetAmountRadioBtn.UseVisualStyleBackColor = true;
            // 
            // LaunchBtn
            // 
            this.LaunchBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.LaunchBtn.Location = new System.Drawing.Point(13, 177);
            this.LaunchBtn.Name = "LaunchBtn";
            this.LaunchBtn.Size = new System.Drawing.Size(159, 45);
            this.LaunchBtn.TabIndex = 1;
            this.LaunchBtn.Text = "Launch";
            this.LaunchBtn.UseVisualStyleBackColor = true;
            this.LaunchBtn.Click += new System.EventHandler(this.LaunchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 234);
            this.Controls.Add(this.LaunchBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SetAmountRadioBtn;
        private System.Windows.Forms.RadioButton WhilePressedRadioBtn;
        private System.Windows.Forms.RadioButton UntilStoppedRadioBtn;
        private System.Windows.Forms.Button LaunchBtn;
    }
}

