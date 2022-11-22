using Main_form.Infra.DAOs;
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

namespace Main_form
{
	public partial class EditUserForm : Form
	{
		private int id;

		public EditUserForm(int id)
		{
			InitializeComponent();

			this.Load += EditUserForm_Load;
			this.id = id;
		}

		private void EditUserForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			// UserVM model = new UserService().Get(id);
			UserDTO dto = new UserDAO().Get(id);

			// 把DTO轉型為ViewModel
			UserVM model = dto.ToUserVM();

			// 再將 viewModel值繫結到各控制項
			txtAccount.Text = model.Account;
			txtPassword.Text = model.Password;
			txtName.Text = model.Name;
			txtEmail.Text = model.Email;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string account = txtAccount.Text;
			string password = txtPassword.Text;
			string name = txtName.Text;
			string email = txtEmail.Text;

			// 將它們繫結到ViewModel
			UserVM model = new UserVM
			{
				Id = this.id,
				Account = account,
				Password = password,
				Name = name,
				Email = email
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


			// update record
			try
			{
				new UserService().Update(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox
			.Show("您真的要刪除嗎?",
					"刪除記錄",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			new UserService().Delete(this.id);


			this.DialogResult = DialogResult.OK;
		}
	}
}
