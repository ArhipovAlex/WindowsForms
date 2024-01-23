namespace WindowsForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.chooseFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ContextMenuStrip = this.contextMenuStrip1;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "The best Alarm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showControlsToolStripMenuItem,
            this.showDateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.chooseFontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 164);
            // 
            // showControlsToolStripMenuItem
            // 
            this.showControlsToolStripMenuItem.Name = "showControlsToolStripMenuItem";
            this.showControlsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showControlsToolStripMenuItem.Text = "Show controls";
            this.showControlsToolStripMenuItem.Click += new System.EventHandler(this.showControlsToolStripMenuItem_Click);
            // 
            // showDateToolStripMenuItem
            // 
            this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
            this.showDateToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showDateToolStripMenuItem.Text = "Show date";
            this.showDateToolStripMenuItem.Click += new System.EventHandler(this.showDateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // chooseFontToolStripMenuItem
            // 
            this.chooseFontToolStripMenuItem.Name = "chooseFontToolStripMenuItem";
            this.chooseFontToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.chooseFontToolStripMenuItem.Text = "Choose font";
            this.chooseFontToolStripMenuItem.Click += new System.EventHandler(this.btnChooseFont_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowDate.Location = new System.Drawing.Point(28, 195);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(170, 36);
            this.cbShowDate.TabIndex = 2;
            this.cbShowDate.Text = "Show date";
            this.cbShowDate.UseVisualStyleBackColor = true;
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(28, 295);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(233, 54);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Hide controls";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(28, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(233, 54);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "The Best Alarm";
            this.notifyIcon1.Visible = true;
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseFont.Location = new System.Drawing.Point(28, 237);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(233, 54);
            this.btnChooseFont.TabIndex = 5;
            this.btnChooseFont.Text = "Choose font";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            this.btnChooseFont.Click += new System.EventHandler(this.btnChooseFont_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontColorToolStripMenuItem1,
            this.backColorToolStripMenuItem1});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // fontColorToolStripMenuItem1
            // 
            this.fontColorToolStripMenuItem1.Name = "fontColorToolStripMenuItem1";
            this.fontColorToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.fontColorToolStripMenuItem1.Text = "Font color";
            this.fontColorToolStripMenuItem1.Click += new System.EventHandler(this.fontColorToolStripMenuItem1_Click);
            // 
            // backColorToolStripMenuItem1
            // 
            this.backColorToolStripMenuItem1.Name = "backColorToolStripMenuItem1";
            this.backColorToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.backColorToolStripMenuItem1.Text = "Back color";
            this.backColorToolStripMenuItem1.Click += new System.EventHandler(this.backColorToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 421);
            this.Controls.Add(this.btnChooseFont);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Clock";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.Button btnHideControls;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.ToolStripMenuItem chooseFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem1;
    }
}

