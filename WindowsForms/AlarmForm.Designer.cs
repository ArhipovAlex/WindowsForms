namespace WindowsForms
{
    partial class AlarmForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmForm));
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbHour = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbMinutes = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbSeconds = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnChooseMusic = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btnSelectSound = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOK.Location = new System.Drawing.Point(12, 333);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(105, 35);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(349, 333);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(105, 35);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(7, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Будильник сработает в";
			// 
			// tbHour
			// 
			this.tbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbHour.Location = new System.Drawing.Point(12, 46);
			this.tbHour.Name = "tbHour";
			this.tbHour.Size = new System.Drawing.Size(66, 30);
			this.tbHour.TabIndex = 3;
			this.tbHour.ModifiedChanged += new System.EventHandler(this.tbHour_ModifiedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(84, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "часов";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(226, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "минут";
			// 
			// tbMinutes
			// 
			this.tbMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbMinutes.Location = new System.Drawing.Point(154, 46);
			this.tbMinutes.Name = "tbMinutes";
			this.tbMinutes.Size = new System.Drawing.Size(66, 30);
			this.tbMinutes.TabIndex = 5;
			this.tbMinutes.ModifiedChanged += new System.EventHandler(this.tbMinutes_ModifiedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(376, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 25);
			this.label4.TabIndex = 8;
			this.label4.Text = "секунд";
			// 
			// tbSeconds
			// 
			this.tbSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbSeconds.Location = new System.Drawing.Point(304, 46);
			this.tbSeconds.Name = "tbSeconds";
			this.tbSeconds.Size = new System.Drawing.Size(66, 30);
			this.tbSeconds.TabIndex = 7;
			this.tbSeconds.ModifiedChanged += new System.EventHandler(this.tbSeconds_ModifiedChanged);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblStatus.Location = new System.Drawing.Point(296, 87);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(74, 25);
			this.lblStatus.TabIndex = 9;
			this.lblStatus.Text = "Status:";
			this.lblStatus.Visible = false;
			// 
			// btnChooseMusic
			// 
			this.btnChooseMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnChooseMusic.Location = new System.Drawing.Point(12, 82);
			this.btnChooseMusic.Name = "btnChooseMusic";
			this.btnChooseMusic.Size = new System.Drawing.Size(278, 35);
			this.btnChooseMusic.TabIndex = 10;
			this.btnChooseMusic.Text = "Choose Music and Add";
			this.btnChooseMusic.UseVisualStyleBackColor = true;
			this.btnChooseMusic.Click += new System.EventHandler(this.btnChooseMusic_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Music files|*.mp3|All files|*.*";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(12, 123);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(439, 196);
			this.listBox1.TabIndex = 11;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker1.Location = new System.Drawing.Point(13, 375);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(277, 22);
			this.dateTimePicker1.TabIndex = 12;
			// 
			// btnSelectSound
			// 
			this.btnSelectSound.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSelectSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectSound.Location = new System.Drawing.Point(130, 333);
			this.btnSelectSound.Name = "btnSelectSound";
			this.btnSelectSound.Size = new System.Drawing.Size(213, 35);
			this.btnSelectSound.TabIndex = 13;
			this.btnSelectSound.Text = "Select sound";
			this.btnSelectSound.UseVisualStyleBackColor = true;
			// 
			// AlarmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 421);
			this.Controls.Add(this.btnSelectSound);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnChooseMusic);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbSeconds);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbMinutes);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbHour);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AlarmForm";
			this.Text = "Настройки будильника";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSeconds;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnChooseMusic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button btnSelectSound;
	}
}