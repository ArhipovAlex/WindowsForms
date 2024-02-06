using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class SettingAlarmForm : Form
	{
		public SettingAlarmForm()
		{
			InitializeComponent();
		}
		public void GetDaysFromBitSet(byte days)
		{
			for(int i=0; i<7;i++)
			{
				int day = 1;
				day <<= i;
				if((days&day)!=0)
				{
					checkedListBox1.SetItemCheckState(i, System.Windows.Forms.CheckState.Checked);
				}
			}
		}
		private void SettingAlarmForm_Load(object sender, EventArgs e)
		{

		}

		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		public byte GetBitSet()
		{
			byte days = 0;
			for(int i=0;i<checkedListBox1.CheckedIndices.Count;i++)
			{
				byte day = (byte)Math.Pow(2, checkedListBox1.CheckedIndices[i]);
				days += day;
			}
			return days;
		}
	}
}
