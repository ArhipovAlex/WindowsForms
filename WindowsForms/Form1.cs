using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Drawing.Imaging;
using WMPLib;
using System.Runtime.InteropServices;

namespace WindowsForms
{
	public partial class Form1 : Form
	{
		string fontFile;
		int size;
		System.Drawing.Font font;
		Color foreground;
		Color background;

		bool showDate;
		bool showControls;
		ChooseFont chooseFont;
		AlarmForm alarmForm;

		int music = 0;//переменная-флаг: 0 - музыка не играет, и не готова играть; 1 - музыка не играет, но готова играть; 2 - музыка играет
		string nameFileMusic = "";//путь до выбранного файла для сигнала будильника
		string Hours = "";//установленные на будильнике часы
		string Minutes = "";//установленные на будильнике минуты
		string Seconds = "";//установленные на будильнике секунды
		List<AlarmList> Records;//список будильников
		struct AlarmList
			{

			public string time { get; set; }
			public DateTime dateDay { get; set; }
			public string name { get; set; }
			public byte weekdays { get; set; }

		}
		List<AlarmList> alarmList;
		WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
		public Form1()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			int startX = Screen.PrimaryScreen.Bounds.Width - this.Width - 25;
			int startY = 25;
			this.SetDesktopLocation(startX, startY);
			ControlsVisibility(false);
			cbShowDate.Checked = false;
			Directory.SetCurrentDirectory("..\\..\\Fonts");
			chooseFont = new ChooseFont();
			alarmForm = new AlarmForm();
			label1.ForeColor = Color.Red;
			label1.BackColor = Color.Black;
			size = 48;
			LoadSettings();
			//Records = new List<string>();
			cbRunAlarm.Enabled = false;//изначально включить будильник нельзя, пока не введены настройки

		}
		void ControlsVisibility(bool visible)
		{
			cbShowDate.Visible = visible;
			btnExit.Visible = visible;
			btnHideControls.Visible = visible;
			btnChooseFont.Visible = visible;
			btnSetupAlarm.Visible = visible;
			cbRunAlarm.Visible = visible;
			this.ShowInTaskbar = visible;
			this.TransparencyKey = !visible ? SystemColors.Control : Color.White;
			this.FormBorderStyle = !visible ? FormBorderStyle.None : FormBorderStyle.Sizable;

		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString("T");
			//label2.Text = DateTime.Now.ToString("yyyy.MM.dd ddd");
			//label2.Visible= cbShowDate.Checked;
			if (cbShowDate.Checked)
			{
				string date = DateTime.Now.ToString("yyyy.MM.dd ddd");
				label1.Text = $"{label1.Text}\n{date}";
			}
			/*
			if(music == 1 &&
				(Convert.ToInt32(Hours) == DateTime.Now.Hour &&
				Convert.ToInt32(Minutes) == DateTime.Now.Minute &&
				Convert.ToInt32(Seconds) == DateTime.Now.Second
				) &&
			cbRunAlarm.Checked
			)//параметры введены и наступает время включить будильник

			{
				WMP.URL = nameFileMusic;
				WMP.settings.volume = 100;
				WMP.controls.play();
				music = 3;//музыка играет
				btnSetupAlarm.Text = "Stop Alarm";
				cbRunAlarm.Enabled = false;
			}*/
			if(cbRunAlarm.Checked)//включена функция Будильник
			{ 
				/*
				foreach (string record in Records)//Перебираем каждую строку и сравниваем время в списке с текущим
				{					
					string timeNow= DateTime.Now.ToString("T");
					string date = record.Split(' ')[0];
					nameFileMusic= record.Substring(9);
					if (date==timeNow&&music==1)//совпало время по списку и музыка готова
					{
						WMP.URL = nameFileMusic;
						WMP.settings.volume = 20;
						WMP.controls.play();
						music = 2;//музыка играет
						btnSetupAlarm.Text = "Stop Alarm";
						cbRunAlarm.Enabled = false;
					}
					if (date == timeNow && music == 2)//совпало время по списку с другим файлом но еще играет другая песня
					{
						WMP.controls.stop();
						WMP.URL= nameFileMusic;
						WMP.settings.volume = 20;
						WMP.controls.play();
					}
				}*/
			}

		}
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			ControlsVisibility(false);
		}
		private void label1_MouseHover(object sender, EventArgs e)
		{
			//ControlsVisibility(true);
			ControlsVisibility(true);
		}

		private void label1_DoubleClick(object sender, EventArgs e)
		{
			ControlsVisibility(true);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveSettings();
			btnExit_Click(sender, e);
		}

		private void showDateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (cbShowDate.Checked)
			{
				cbShowDate.Checked = false;
				//showDateToolStripMenuItem.Text = "Show date";
				timer1_Tick(sender, e);
				showDateToolStripMenuItem.Checked = false;
			}
			else
			{
				cbShowDate.Checked = true;
				//showDateToolStripMenuItem.Text = "Hide date";
				timer1_Tick(sender, e);
				showDateToolStripMenuItem.Checked = true;
			}
		}

		private void showControlsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btnExit.Visible)
			{
				ControlsVisibility(false);
				//showControlsToolStripMenuItem.Text = "Show controls"; 
				showControlsToolStripMenuItem.Checked = false;
			}
			else
			{
				showControlsToolStripMenuItem.Checked = true;
				//showControlsToolStripMenuItem.Text = "Hide controls";
				ControlsVisibility(true);
			}

		}

		private void btnChooseFont_Click(object sender, EventArgs e)
		{
			DialogResult result = chooseFont.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				label1.Font = chooseFont.NewFont;
				fontFile = chooseFont.AllFonts[chooseFont.Index];
			}
		}
		public void SaveSettings()
		{
			StreamWriter sw = new StreamWriter("Settings.cfg");
			sw.WriteLine(fontFile);
			sw.WriteLine(label1.Font.Size);
			sw.WriteLine(label1.ForeColor.ToArgb());
			sw.WriteLine(label1.BackColor.ToArgb());
			sw.Close();
		}
		public void LoadSettings()
		{
			//Directory.SetCurrentDirectory("..\\..\\Fonts");
			//MessageBox.Show(this, Directory.GetCurrentDirectory());
			StreamReader sr = new StreamReader("Settings.cfg");
			fontFile = sr.ReadLine();
			size = Convert.ToInt32(sr.ReadLine());
			foreground = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
			background = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
			//fontIndex = Convert.ToInt32(sr.ReadLine());
			sr.Close();

			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile(fontFile);
			System.Drawing.Font font = new System.Drawing.Font(pfc.Families[0], size);
			label1.Font = font;
			label1.BackColor = background;
			label1.ForeColor = foreground;
		}
		private void fontColorToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog1 = new ColorDialog();
			//colorDialog1.FullOpen= true;
			DialogResult result = colorDialog1.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				label1.ForeColor = colorDialog1.Color;
			}
		}

		private void backColorToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog1 = new ColorDialog();
			//colorDialog1.FullOpen= true;
			DialogResult result = colorDialog1.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				label1.BackColor = colorDialog1.Color;
			}
		}

		private void btnSetupAlarm_Click(object sender, EventArgs e)//вызов окна настроек и передача в случае нормальных настроек
		{
			if (music == 0 || music==1) //кнопка работает для установки параметров
			{
				DialogResult result = alarmForm.ShowDialog(this);
				if (result == DialogResult.OK)//принимаем параметры и даем возможность активировать будильник
				{
					//Hours = alarmForm.Hours;
					//Minutes = alarmForm.Minutes;
					//Seconds = alarmForm.Seconds;
					//nameFileMusic = alarmForm.nameFileMusic;
					if (alarmForm.Records.Count == 0)
					{
						Records.Clear();
						music = 0;
					}
					else 
					{	
						cbRunAlarm.Enabled = true;
						music = 1;
						//for (int i = 0; i < alarmForm.Records.Count; i++)
						//{
						//	Records[i] = alarmForm.Records[i];
						//}
						foreach(string element in alarmForm.Records)
						{
							//Records.Add(element);
							//Console.WriteLine(element);
						}
					}
				}
				else //иначе очищаем параметры и снимаем активацию будильника
				{
					music = 0;
					Hours = null;
					Minutes = null;
					Seconds = null;
					nameFileMusic = null;
					cbRunAlarm.Enabled = false;
					cbRunAlarm.Checked = false;
				}
			}
			else if (music == 2)//музыка играет и кнопка работает для остановки будильника
			{
				WMP.controls.stop();
				btnSetupAlarm.Text = "Setup Alarm";
				cbRunAlarm.Enabled = true;
				cbRunAlarm.Checked = false;
				music = 0;
			}
		}
	}
}