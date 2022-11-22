using ISpan.Utility;
using Main_form.Forms.Template;
using Main_form.Infra.Extensions;
using Main_form.models.viewmodels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_form
{
	public partial class TemplateForm : Form
	{
		private TemplateVM[] templates = null;
		public TemplateForm()
		{
			InitializeComponent();
			DisplayTemplates();
		}


		//未完成
		private void btnUploadImage_Click(object sender, EventArgs e)
		{
			var frm = new UploadTemplateForm();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayTemplates();
			}
		}

		private void DisplayTemplates()
		{
			string sql = @"SELECT * FROM template";

			SqlParameter[] parameters = new SqlParameter[] { };

			var dbHelper = new SqlDbHelper("default");

			templates = dbHelper.Select(sql, parameters)
					.AsEnumerable()
					.Select(row => ParseToIndexVM(row))
					.ToArray();

			BindData(templates);
		}

		private void BindData(TemplateVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private TemplateVM ParseToIndexVM(DataRow row)
		{
			return new TemplateVM
			{
				Id = row.Field<int>("Id"),
				Template_Name = row.Field<string>("Template_Name"),
				//Photo = row.Field<byte[]>("photo"),
			};
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			TemplateVM row = this.templates[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的名字

			// 把 id 傳給 pictureBox以顯示圖片

			string sql = "SELECT photo FROM template WHERE id=@id";
			var parameters = new SqlParameterBuilder()
				.AddInt("id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			DataRow rows = data.Rows[0];

			pictureBox1.Image = rows.Field<byte[]>("photo").ConvertByteArrayToImage();
			label123.Text = id.ToString();

		}

		private void btnMakeMeme_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null) return;
			operationPanel.Controls.Clear();
			operationPanel.LoadForm(new MemeForm(label123.Text.ToInt(-1)));
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null) return;
			SaveFileDialog saveDialog = new SaveFileDialog();

			saveDialog.FileName = "I want to use this template!";
			saveDialog.DefaultExt = "jpg";
			saveDialog.Filter = "JPG Image | *.jpg";
			saveDialog.ValidateNames = true;

			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				int width = Convert.ToInt32(pictureBox1.Width);
				int height = Convert.ToInt32(pictureBox1.Height);
				Bitmap bmp = new Bitmap(width, height);
				pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
				bmp.Save(saveDialog.FileName, ImageFormat.Jpeg);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to delete this?",
				"delete this template",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question) != DialogResult.Yes) return;

			string sql = @"DELETE FROM template WHERE Id=@Id";

			var parameters = new SqlParameterBuilder()
				.AddInt("Id", label123.Text.ToInt())
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			pictureBox1.Image = null;
			DisplayTemplates();
		}
	}
}
