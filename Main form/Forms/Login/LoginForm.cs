using Main_form.Forms.Login;
using Main_form.Forms.Template;
using Main_form.Infra.Extensions;
using Main_form.models.services;
using Main_form.models.viewmodels;
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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// 將表單欄位值繫結到view model
			LoginVM model = new LoginVM
			{
				Account = txtAccount.Text,
				Password = txtPassword.Text
			};

			// 驗證欄位輸入是否正確
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", txtAccount},
				{"Password", txtPassword},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			// 判斷帳密是否正確
			bool result = new UserService().Authenticate(model);
			if (result == false)
			{
				MessageBox.Show("帳號或密碼錯誤");
				return;
			}

			// 若正確, 就開啟MainForm
			txtAccount.Text = String.Empty;
			txtPassword.Text = String.Empty;

			var frm = new MainForm();
			frm.Owner = this;

			frm.ShowDialog();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var frm = new RegisterForm();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				
			}
		}
	}
}
