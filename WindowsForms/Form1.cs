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
        public Form1()
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.Manual;
            int startX = Screen.PrimaryScreen.Bounds.Width - this.Width - 25;
            int startY = 25;
            this.SetDesktopLocation(startX, startY);
            ControlsVisibility(false);
            cbShowDate.Checked= false;
            Directory.SetCurrentDirectory("..\\..\\Fonts");
            chooseFont = new ChooseFont();
            label1.ForeColor = Color.Red;
            label1.BackColor = Color.Black;
            size = 48;
            LoadSettings();
        }
        void ControlsVisibility(bool visible)
        {
            cbShowDate.Visible = visible;
            btnExit.Visible = visible;
            btnHideControls.Visible = visible;
            btnChooseFont.Visible = visible;
            this.ShowInTaskbar= visible;
            this.TransparencyKey = !visible ? SystemColors.Control : Color.White;
            this.FormBorderStyle = !visible ? FormBorderStyle.None : FormBorderStyle.Sizable;
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("T");
            //label2.Text = DateTime.Now.ToString("yyyy.MM.dd ddd");
            //label2.Visible= cbShowDate.Checked;
            if(cbShowDate.Checked)
            {
                string date = DateTime.Now.ToString("yyyy.MM.dd ddd");
                label1.Text = $"{label1.Text}\n{date}";
            }
        }

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
            btnExit_Click(sender,e);
        }

        private void showDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cbShowDate.Checked)
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
                showDateToolStripMenuItem.Checked= true;
            }
        }

        private void showControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(btnExit.Visible) 
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
            DialogResult result= chooseFont.ShowDialog(this);
            if(result==DialogResult.OK) 
            { 
                label1.Font= chooseFont.NewFont;
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
            DialogResult result=colorDialog1.ShowDialog(this);
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
    }
}