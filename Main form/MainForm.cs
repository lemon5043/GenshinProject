using Main_form.Infra.Extensions;
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
			mainPanel.LoadForm(new HomeForm());
		}

		//private void btnAdmin_Click(object sender, EventArgs e)
		//{
		//	mainPanel.LoadForm(new AdminForm());
		//}

		private void btnTemplate_Click(object sender, EventArgs e)
		{
			mainPanel.LoadForm(new TemplateForm());
		}

		private void btnPhoto_Click(object sender, EventArgs e)
		{
			mainPanel.LoadForm(new MemeForm());
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			mainPanel.LoadForm(new ManageUserForm());
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			mainPanel.LoadForm(new HomeForm());
		}
	}
}
