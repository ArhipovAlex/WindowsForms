using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class AlarmForm : Form
    {
        public List<string> Records;
        public string nameFileMusic = "";//путь до выбранного файла для сигнала будильника
        public string Hours = "";//установленные на будильнике часы
        public string Minutes = "";//установленные на будильнике минуты
        public string Seconds = "";//установленные на будильнике секунды
        public AlarmForm()
        {
            InitializeComponent();
            tbHour.Text =DateTime.Now.Hour.ToString();
            tbMinutes.Text = DateTime.Now.Minute.ToString();
            tbSeconds.Text = DateTime.Now.Second.ToString();
            Records= new List<string>();
            //Records = new string[10];
            CheckStatus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Hours=tbHour.Text;
            Minutes=tbMinutes.Text;
            Seconds=tbSeconds.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckStatus()
        {
            lblStatus.Text = "Status:";
            if (CorrectHour() && CorrectMinutes() && CorrectSecond())
            {
                lblStatus.Text += "\nCorrect Time";
                tbHour.ForeColor = Color.Green;
                tbMinutes.ForeColor = Color.Green;
                tbSeconds.ForeColor = Color.Green;
            }
            else
            {
                lblStatus.Text += "\nWrong Time: ";
            }
            if (!(CorrectHour()))
            {
                lblStatus.Text += "check Hours ";
                tbHour.ForeColor= Color.Red;
            }
            else 
            { 
                tbHour.ForeColor = Color.Black; 
            }
            if(!(CorrectMinutes()))
            {
                lblStatus.Text += "check Minutes ";
                tbMinutes.ForeColor= Color.Red;
            }
            else 
            { 
                tbMinutes.ForeColor = Color.Black; 
            }
            if(!(CorrectSecond()))
            {
                lblStatus.Text += "check Seconds";
                tbSeconds.ForeColor= Color.Red;
            }
            else
            {
                tbSeconds.ForeColor = Color.Black;
            }
            if(nameFileMusic!= "")
            {
                lblStatus.Text += "\nCorrect Music:\n";
                lblStatus.Text += nameFileMusic;
            }
            else
            {
                lblStatus.Text += "\nWrong Music: choose music file";
            }
        }

        private bool CorrectHour()
        {
            bool result = false;
            if (Convert.ToInt32(tbHour.Text) >= 0 && Convert.ToInt32(tbHour.Text) <= 23) { result = true; }
            return result;
        }
        private bool CorrectMinutes()
        {
            bool result = false;
            if (Convert.ToInt32(tbMinutes.Text) >= 0 && Convert.ToInt32(tbMinutes.Text) <= 59) { result = true; }
            return result;
        }
        private bool CorrectSecond()
        {
            bool result = false;
            if (Convert.ToInt32(tbSeconds.Text) >= 0 && Convert.ToInt32(tbSeconds.Text) <= 59) { result = true; }
            return result;
        }

        private void tbHour_ModifiedChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }
        private void tbMinutes_ModifiedChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }
        private void tbSeconds_ModifiedChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }
        private void btnChooseMusic_Click(object sender, EventArgs e)
        {
            if (!(CorrectHour() && CorrectMinutes() && CorrectSecond())) return;//если время неправильное не даем внести запись в ListBox
            //string extension = "";//расширение выбранного файла
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                nameFileMusic= openFileDialog1.FileName;
                //extension=Path.GetExtension(nameFileMusic);
                //if(extension!=".mp3")
                //{
                //    MessageBox.Show("Not mp3-file!");
                //    nameFileMusic = "";
                //    return;
                //}
            }
            if(tbHour.Text.Length==1)tbHour.Text="0"+tbHour.Text;
            if(tbMinutes.Text.Length==1)tbMinutes.Text="0"+tbMinutes.Text;
            if(tbSeconds.Text.Length==1)tbSeconds.Text="0"+tbSeconds.Text;
            Records.Add(tbHour.Text+":"+tbMinutes.Text+":"+tbSeconds.Text+" "+nameFileMusic);
            lblRecord.Text= lblRecord.Text+Records.Last() +"\n";
            string Record= tbHour.Text + ":"+ tbMinutes.Text + ":"+ tbSeconds.Text + " "+nameFileMusic.Split('\\').Last();
            listBox1.Items.Add(Record);
            CheckStatus();
        }
    }
}
