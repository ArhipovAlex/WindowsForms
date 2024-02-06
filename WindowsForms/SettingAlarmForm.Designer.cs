namespace WindowsForms
{
	partial class SettingAlarmForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingAlarmForm));
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.cbHour = new System.Windows.Forms.ComboBox();
			this.lblHour = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbMinutes = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btnSelectMusic = new System.Windows.Forms.Button();
			this.btnPlayMusic = new System.Windows.Forms.Button();
			this.lblMusic = new System.Windows.Forms.Label();
			this.rbIn10sec = new System.Windows.Forms.RadioButton();
			this.rbIn1min = new System.Windows.Forms.RadioButton();
			this.rbIn5min = new System.Windows.Forms.RadioButton();
			this.rbInFullRecord = new System.Windows.Forms.RadioButton();
			this.gbIntervals = new System.Windows.Forms.GroupBox();
			this.gbRepeats = new System.Windows.Forms.GroupBox();
			this.rbRepeatUnlim = new System.Windows.Forms.RadioButton();
			this.rbRepeat3Times = new System.Windows.Forms.RadioButton();
			this.rbRepeatNo = new System.Windows.Forms.RadioButton();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.WMPTest = new AxWMPLib.AxWindowsMediaPlayer();
			this.gbIntervals.SuspendLayout();
			this.gbRepeats.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WMPTest)).BeginInit();
			this.SuspendLayout();
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.ColumnWidth = 69;
			this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun"});
			this.checkedListBox1.Location = new System.Drawing.Point(12, 94);
			this.checkedListBox1.MultiColumn = true;
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(489, 29);
			this.checkedListBox1.TabIndex = 0;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			// 
			// cbHour
			// 
			this.cbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbHour.FormattingEnabled = true;
			this.cbHour.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
			this.cbHour.Location = new System.Drawing.Point(67, 19);
			this.cbHour.Name = "cbHour";
			this.cbHour.Size = new System.Drawing.Size(79, 33);
			this.cbHour.TabIndex = 1;
			// 
			// lblHour
			// 
			this.lblHour.AutoSize = true;
			this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblHour.Location = new System.Drawing.Point(7, 22);
			this.lblHour.Name = "lblHour";
			this.lblHour.Size = new System.Drawing.Size(54, 25);
			this.lblHour.TabIndex = 2;
			this.lblHour.Text = "Hour";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(162, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Minute";
			// 
			// cbMinutes
			// 
			this.cbMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbMinutes.FormattingEnabled = true;
			this.cbMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
			this.cbMinutes.Location = new System.Drawing.Point(239, 19);
			this.cbMinutes.Name = "cbMinutes";
			this.cbMinutes.Size = new System.Drawing.Size(79, 33);
			this.cbMinutes.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(336, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Second";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
			this.comboBox1.Location = new System.Drawing.Point(422, 19);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(79, 33);
			this.comboBox1.TabIndex = 5;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.Location = new System.Drawing.Point(263, 58);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(238, 30);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// btnSelectMusic
			// 
			this.btnSelectMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectMusic.Location = new System.Drawing.Point(12, 129);
			this.btnSelectMusic.Name = "btnSelectMusic";
			this.btnSelectMusic.Size = new System.Drawing.Size(134, 37);
			this.btnSelectMusic.TabIndex = 8;
			this.btnSelectMusic.Text = "Select Music";
			this.btnSelectMusic.UseVisualStyleBackColor = true;
			// 
			// btnPlayMusic
			// 
			this.btnPlayMusic.Enabled = false;
			this.btnPlayMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPlayMusic.Location = new System.Drawing.Point(12, 172);
			this.btnPlayMusic.Name = "btnPlayMusic";
			this.btnPlayMusic.Size = new System.Drawing.Size(134, 37);
			this.btnPlayMusic.TabIndex = 9;
			this.btnPlayMusic.Text = "Play Music";
			this.btnPlayMusic.UseVisualStyleBackColor = true;
			// 
			// lblMusic
			// 
			this.lblMusic.AutoSize = true;
			this.lblMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblMusic.Location = new System.Drawing.Point(152, 135);
			this.lblMusic.Name = "lblMusic";
			this.lblMusic.Size = new System.Drawing.Size(0, 25);
			this.lblMusic.TabIndex = 10;
			// 
			// rbIn10sec
			// 
			this.rbIn10sec.AutoSize = true;
			this.rbIn10sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbIn10sec.Location = new System.Drawing.Point(6, 29);
			this.rbIn10sec.Name = "rbIn10sec";
			this.rbIn10sec.Size = new System.Drawing.Size(159, 29);
			this.rbIn10sec.TabIndex = 11;
			this.rbIn10sec.TabStop = true;
			this.rbIn10sec.Text = "Interval 10 sec";
			this.rbIn10sec.UseVisualStyleBackColor = true;
			// 
			// rbIn1min
			// 
			this.rbIn1min.AutoSize = true;
			this.rbIn1min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbIn1min.Location = new System.Drawing.Point(6, 64);
			this.rbIn1min.Name = "rbIn1min";
			this.rbIn1min.Size = new System.Drawing.Size(148, 29);
			this.rbIn1min.TabIndex = 12;
			this.rbIn1min.TabStop = true;
			this.rbIn1min.Text = "Interval 1 min";
			this.rbIn1min.UseVisualStyleBackColor = true;
			// 
			// rbIn5min
			// 
			this.rbIn5min.AutoSize = true;
			this.rbIn5min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbIn5min.Location = new System.Drawing.Point(6, 99);
			this.rbIn5min.Name = "rbIn5min";
			this.rbIn5min.Size = new System.Drawing.Size(148, 29);
			this.rbIn5min.TabIndex = 13;
			this.rbIn5min.TabStop = true;
			this.rbIn5min.Text = "Interval 5 min";
			this.rbIn5min.UseVisualStyleBackColor = true;
			// 
			// rbInFullRecord
			// 
			this.rbInFullRecord.AutoSize = true;
			this.rbInFullRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbInFullRecord.Location = new System.Drawing.Point(6, 134);
			this.rbInFullRecord.Name = "rbInFullRecord";
			this.rbInFullRecord.Size = new System.Drawing.Size(131, 29);
			this.rbInFullRecord.TabIndex = 14;
			this.rbInFullRecord.TabStop = true;
			this.rbInFullRecord.Text = "Full Record";
			this.rbInFullRecord.UseVisualStyleBackColor = true;
			// 
			// gbIntervals
			// 
			this.gbIntervals.Controls.Add(this.rbIn10sec);
			this.gbIntervals.Controls.Add(this.rbInFullRecord);
			this.gbIntervals.Controls.Add(this.rbIn1min);
			this.gbIntervals.Controls.Add(this.rbIn5min);
			this.gbIntervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbIntervals.Location = new System.Drawing.Point(12, 216);
			this.gbIntervals.Name = "gbIntervals";
			this.gbIntervals.Size = new System.Drawing.Size(220, 174);
			this.gbIntervals.TabIndex = 15;
			this.gbIntervals.TabStop = false;
			this.gbIntervals.Text = "Intervals";
			// 
			// gbRepeats
			// 
			this.gbRepeats.Controls.Add(this.rbRepeatUnlim);
			this.gbRepeats.Controls.Add(this.rbRepeat3Times);
			this.gbRepeats.Controls.Add(this.rbRepeatNo);
			this.gbRepeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbRepeats.Location = new System.Drawing.Point(253, 216);
			this.gbRepeats.Name = "gbRepeats";
			this.gbRepeats.Size = new System.Drawing.Size(248, 128);
			this.gbRepeats.TabIndex = 16;
			this.gbRepeats.TabStop = false;
			this.gbRepeats.Text = "Repeats";
			// 
			// rbRepeatUnlim
			// 
			this.rbRepeatUnlim.AutoSize = true;
			this.rbRepeatUnlim.Location = new System.Drawing.Point(10, 99);
			this.rbRepeatUnlim.Name = "rbRepeatUnlim";
			this.rbRepeatUnlim.Size = new System.Drawing.Size(158, 29);
			this.rbRepeatUnlim.TabIndex = 2;
			this.rbRepeatUnlim.TabStop = true;
			this.rbRepeatUnlim.Text = "Unlimit Repeat";
			this.rbRepeatUnlim.UseVisualStyleBackColor = true;
			// 
			// rbRepeat3Times
			// 
			this.rbRepeat3Times.AutoSize = true;
			this.rbRepeat3Times.Location = new System.Drawing.Point(10, 64);
			this.rbRepeat3Times.Name = "rbRepeat3Times";
			this.rbRepeat3Times.Size = new System.Drawing.Size(162, 29);
			this.rbRepeat3Times.TabIndex = 1;
			this.rbRepeat3Times.TabStop = true;
			this.rbRepeat3Times.Text = "Repeat 3 times";
			this.rbRepeat3Times.UseVisualStyleBackColor = true;
			// 
			// rbRepeatNo
			// 
			this.rbRepeatNo.AutoSize = true;
			this.rbRepeatNo.Location = new System.Drawing.Point(10, 29);
			this.rbRepeatNo.Name = "rbRepeatNo";
			this.rbRepeatNo.Size = new System.Drawing.Size(118, 29);
			this.rbRepeatNo.TabIndex = 0;
			this.rbRepeatNo.TabStop = true;
			this.rbRepeatNo.Text = "No repeat";
			this.rbRepeatNo.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOK.Location = new System.Drawing.Point(253, 350);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(123, 40);
			this.btnOK.TabIndex = 17;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(382, 350);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(119, 40);
			this.btnCancel.TabIndex = 18;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// WMPTest
			// 
			this.WMPTest.Enabled = true;
			this.WMPTest.Location = new System.Drawing.Point(167, 172);
			this.WMPTest.Name = "WMPTest";
			this.WMPTest.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPTest.OcxState")));
			this.WMPTest.Size = new System.Drawing.Size(334, 37);
			this.WMPTest.TabIndex = 19;
			this.WMPTest.Visible = false;
			// 
			// SettingAlarmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 393);
			this.Controls.Add(this.WMPTest);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.gbRepeats);
			this.Controls.Add(this.gbIntervals);
			this.Controls.Add(this.lblMusic);
			this.Controls.Add(this.btnPlayMusic);
			this.Controls.Add(this.btnSelectMusic);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbMinutes);
			this.Controls.Add(this.lblHour);
			this.Controls.Add(this.cbHour);
			this.Controls.Add(this.checkedListBox1);
			this.Name = "SettingAlarmForm";
			this.Text = "Settings Alarm";
			this.Load += new System.EventHandler(this.SettingAlarmForm_Load);
			this.gbIntervals.ResumeLayout(false);
			this.gbIntervals.PerformLayout();
			this.gbRepeats.ResumeLayout(false);
			this.gbRepeats.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WMPTest)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.ComboBox cbHour;
		private System.Windows.Forms.Label lblHour;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbMinutes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button btnSelectMusic;
		private System.Windows.Forms.Button btnPlayMusic;
		private System.Windows.Forms.Label lblMusic;
		private System.Windows.Forms.RadioButton rbIn10sec;
		private System.Windows.Forms.RadioButton rbIn1min;
		private System.Windows.Forms.RadioButton rbIn5min;
		private System.Windows.Forms.RadioButton rbInFullRecord;
		private System.Windows.Forms.GroupBox gbIntervals;
		private System.Windows.Forms.GroupBox gbRepeats;
		private System.Windows.Forms.RadioButton rbRepeatUnlim;
		private System.Windows.Forms.RadioButton rbRepeat3Times;
		private System.Windows.Forms.RadioButton rbRepeatNo;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private AxWMPLib.AxWindowsMediaPlayer WMPTest;
	}
}