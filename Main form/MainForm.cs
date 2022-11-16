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
		public void LoadForm(object form)
		{
			if (this.mainPanel.Controls.Count > 0) { this.mainPanel.Controls.RemoveAt(0); }
			Form f = form as Form;
			f.TopLevel = false;
			f.Dock = DockStyle.Fill;
			this.mainPanel.Controls.Add(f);
			this.mainPanel.Tag = f;
			f.Show();
		}

		private void btnAdmin_Click(object sender, EventArgs e)
		{
			LoadForm(new AdminForm());
		}

		private void btnTemplate_Click(object sender, EventArgs e)
		{
			LoadForm(new TemplateForm());
		}

		private void btnPhoto_Click(object sender, EventArgs e)
		{
			LoadForm(new PhotoForm());
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			LoadForm(new UserForm());
		}
	}
}
