﻿using System;
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
    public partial class ChoseForm : Form
    {
        string[] allFonts;
        public System.Drawing.Font NewFont { get; set; }
        public ChoseForm()
        {
            InitializeComponent();
            allFonts = Directory.GetFiles(Directory.GetCurrentDirectory(),"*.?tf", SearchOption.AllDirectories);
            foreach (string i in allFonts)
            {
                cbFonts.Items.Add(i.Split('\\').Last());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            //MessageBox.Show(currentDirectory);
            NewFont = lblExample.Font;
            this.Close();
        }

        private void cbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFullName.Text = allFonts[cbFonts.SelectedIndex];
            PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile(cbFonts.SelectedItem.ToString());
            pfc.AddFontFile(allFonts[cbFonts.SelectedIndex]);
            //MessageBox.Show(this, allFonts[cbFonts.SelectedIndex]);
            NewFont = new Font(pfc.Families[0], 48);
            lblExample.Font = NewFont;
        }
    }
}
