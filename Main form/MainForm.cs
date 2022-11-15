using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_form
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		public void loadForm(object form)
		{
			if (this.mainPanel.Controls.Count > 0) { this.mainPanel.Controls.RemoveAt(0); }
			Form f = form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.mainPanel.Controls.Add(f);
			this.mainPanel.Tag = f;
			f.Show();
		}

		private void btnCharacter_Click(object sender, EventArgs e)
		{
			loadForm(new CharacterForm());
		}

		private void btnWeapen_Click(object sender, EventArgs e)
		{
			loadForm(new WeapenForm());
		}

		private void btnSetting_Click(object sender, EventArgs e)
		{
			loadForm(new SettingForm());
		}
	}
}
