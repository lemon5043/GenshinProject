using ISpan.Utility;
using Main_form.Infra.Extensions;
using Main_form.models.viewmodels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_form
{
	public partial class HomeForm : Form
	{
		private MemeVM[] memes = null;
		public HomeForm()
		{
			InitializeComponent();
			DisplayMemes();
		}

		private void DisplayMemes()
		{
			string sql = @"SELECT * FROM meme";

			SqlParameter[] parameters = new SqlParameter[] { };

			var dbHelper = new SqlDbHelper("default");

			memes = dbHelper.Select(sql, parameters)
					.AsEnumerable()
					.Select(row => ParseToIndexVM(row))
					.ToArray();

			BindData(memes);
		}

		private void BindData(MemeVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private MemeVM ParseToIndexVM(DataRow row)
		{
			return new MemeVM
			{
				Id = row.Field<int>("Id"),
				Template_Id = row.Field<int>("Template_Id"),
				Name = row.Field<string>("Name"),
				//Photo = row.Field<byte[]>("photo"),
			};
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			MemeVM row = this.memes[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的名字

			// 把 id 傳給 pictureBox以顯示圖片

			string sql = "SELECT meme FROM meme WHERE id=@id";
			var parameters = new SqlParameterBuilder()
				.AddInt("id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			DataRow rows = data.Rows[0];

			label123.Text = id.ToString();
			pictureBox1.Image = rows.Field<byte[]>("meme").ConvertByteArrayToImage();

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to delete this?",
				"delete this meme",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) != DialogResult.Yes) return;

			string sql = @"DELETE FROM meme WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", label123.Text.ToInt())
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			pictureBox1.Image = null;
			DisplayMemes();
		}
	}
}
