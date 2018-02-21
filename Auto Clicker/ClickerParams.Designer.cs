namespace Auto_Clicker
{
    partial class ClickerParams
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
            this.components = new System.ComponentModel.Container();
            this.RecordCmdBtn = new System.Windows.Forms.Button();
            this.CommandKeyLbl = new System.Windows.Forms.Label();
            this.ClickTimeTxt = new System.Windows.Forms.TextBox();
            this.ClickNumberTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.timerLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ClickerParamsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.untilStoppedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whilePressedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.timesClickedLbl = new System.Windows.Forms.Label();
            this.ClickerParamsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecordCmdBtn
            // 
            this.RecordCmdBtn.Location = new System.Drawing.Point(12, 10);
            this.RecordCmdBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecordCmdBtn.Name = "RecordCmdBtn";
            this.RecordCmdBtn.Size = new System.Drawing.Size(172, 25);
            this.RecordCmdBtn.TabIndex = 0;
            this.RecordCmdBtn.Text = "Record Command Key";
            this.RecordCmdBtn.UseVisualStyleBackColor = true;
            this.RecordCmdBtn.Click += new System.EventHandler(this.RecordCmdBtn_Click);
            // 
            // CommandKeyLbl
            // 
            this.CommandKeyLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommandKeyLbl.Location = new System.Drawing.Point(12, 48);
            this.CommandKeyLbl.Name = "CommandKeyLbl";
            this.CommandKeyLbl.Size = new System.Drawing.Size(173, 25);
            this.CommandKeyLbl.TabIndex = 1;
            // 
            // ClickTimeTxt
            // 
            this.ClickTimeTxt.Location = new System.Drawing.Point(11, 110);
            this.ClickTimeTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClickTimeTxt.Name = "ClickTimeTxt";
            this.ClickTimeTxt.Size = new System.Drawing.Size(89, 22);
            this.ClickTimeTxt.TabIndex = 2;
            // 
            // ClickNumberTxt
            // 
            this.ClickNumberTxt.Location = new System.Drawing.Point(11, 161);
            this.ClickNumberTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClickNumberTxt.Name = "ClickNumberTxt";
            this.ClickNumberTxt.Size = new System.Drawing.Size(89, 22);
            this.ClickNumberTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time Between Clicks (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Clicks";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(11, 190);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(102, 30);
            this.startBtn.TabIndex = 6;
            this.startBtn.Text = "Start Clicking";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(147, 190);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(102, 30);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "Stop Clicking";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // timerLbl
            // 
            this.timerLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timerLbl.Location = new System.Drawing.Point(268, 33);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(118, 25);
            this.timerLbl.TabIndex = 8;
            this.timerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Clicking Begins in:";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(283, 190);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(102, 30);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ClickerParamsMenu
            // 
            this.ClickerParamsMenu.AllowDrop = true;
            this.ClickerParamsMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ClickerParamsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ClickerParamsMenu.Name = "ClickerParamsMenu";
            this.ClickerParamsMenu.Size = new System.Drawing.Size(118, 52);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.untilStoppedToolStripMenuItem,
            this.whilePressedToolStripMenuItem,
            this.setAmountToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // untilStoppedToolStripMenuItem
            // 
            this.untilStoppedToolStripMenuItem.Checked = true;
            this.untilStoppedToolStripMenuItem.CheckOnClick = true;
            this.untilStoppedToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.untilStoppedToolStripMenuItem.Name = "untilStoppedToolStripMenuItem";
            this.untilStoppedToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.untilStoppedToolStripMenuItem.Text = "Until Stopped";
            this.untilStoppedToolStripMenuItem.Click += new System.EventHandler(this.untilStoppedToolStripMenuItem_Click);
            // 
            // whilePressedToolStripMenuItem
            // 
            this.whilePressedToolStripMenuItem.CheckOnClick = true;
            this.whilePressedToolStripMenuItem.Name = "whilePressedToolStripMenuItem";
            this.whilePressedToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.whilePressedToolStripMenuItem.Text = "While Pressed";
            this.whilePressedToolStripMenuItem.Click += new System.EventHandler(this.whilePressedToolStripMenuItem_Click);
            // 
            // setAmountToolStripMenuItem
            // 
            this.setAmountToolStripMenuItem.CheckOnClick = true;
            this.setAmountToolStripMenuItem.Name = "setAmountToolStripMenuItem";
            this.setAmountToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.setAmountToolStripMenuItem.Text = "Set Amount";
            this.setAmountToolStripMenuItem.Click += new System.EventHandler(this.setAmountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Times Clicked";
            // 
            // timesClickedLbl
            // 
            this.timesClickedLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timesClickedLbl.Location = new System.Drawing.Point(268, 98);
            this.timesClickedLbl.Name = "timesClickedLbl";
            this.timesClickedLbl.Size = new System.Drawing.Size(118, 25);
            this.timesClickedLbl.TabIndex = 11;
            this.timesClickedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClickerParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 230);
            this.ContextMenuStrip = this.ClickerParamsMenu;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timesClickedLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClickNumberTxt);
            this.Controls.Add(this.ClickTimeTxt);
            this.Controls.Add(this.CommandKeyLbl);
            this.Controls.Add(this.RecordCmdBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClickerParams";
            this.Text = "ClickerParams";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClickerParams_FormClosing);
            this.Load += new System.EventHandler(this.ClickerParams_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClickerParams_KeyPress);
            this.ClickerParamsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RecordCmdBtn;
        private System.Windows.Forms.Label CommandKeyLbl;
        private System.Windows.Forms.TextBox ClickTimeTxt;
        private System.Windows.Forms.TextBox ClickNumberTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ContextMenuStrip ClickerParamsMenu;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem untilStoppedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whilePressedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timesClickedLbl;
    }
}