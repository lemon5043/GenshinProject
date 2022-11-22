using Main_form.Infra.Extensions;
using Main_form.models.DTOs;
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

namespace Main_form.Forms.Login
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			if(txtPassword.Text != txtConfirmPassword.Text)
			{
				MessageBox.Show("Passwords did not match!");
				return;
			}
			// 取得表單的各欄位值
			string account = txtAccount.Text;
			string password = txtPassword.Text;
			string name = txtName.Text;
			string email = txtEmail.Text;

			// 將它們繫結到ViewModel
			UserVM model = new UserVM
			{
				Account = account,
				Password = password,
				Name = name,
				Email = email,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", txtAccount},
				{"Password", txtPassword},
				{"Name", txtName},
				{"email", txtEmail},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			// 如果通過驗證,就新增記錄 
			// 將ViewModel轉成DTO
			UserDTO dto = model.ToDTO();


			try
			{
				// new UserService().Create(model);
				new UserService().Create(dto);
				MessageBox.Show("Your account has already created successfully.");

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
		}
	}
}
