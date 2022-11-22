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
	public partial class AdminForm : Form
	{
		public AdminForm()
		{
			InitializeComponent();
		}

		private void btnManageUser_Click(object sender, EventArgs e)
		{
			operationPanel.LoadForm(new ManageUserForm());
		}

		private void btnManageMeme_Click(object sender, EventArgs e)
		{

		}
	}
}
