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
	public partial class ManageUserForm : Form
	{
		public ManageUserForm()
		{
			InitializeComponent();
			// 顯示記錄
			DisplayUsers();
		}

		private UserIndexVM[] users = null;

		private void DisplayUsers()
		{

			users = new UserDAO().GetAll()
						.Select(dto => dto.ToUserIndexVM())
						.ToArray();
			BindData(users);
		}


		private void BindData(UserIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		//private void addnewButton_Click(object sender, EventArgs e)
		//{
		//	var frm = new CreateUserForm();
		//	DialogResult result = frm.ShowDialog();

		//	if (result == DialogResult.OK)
		//	{
		//		DisplayUsers();
		//	}
		//}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			UserIndexVM row = this.users[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			//把 id 傳給編輯表單的建構函數
		   var frm = new EditUserForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayUsers();
			}

		}
	}
}
