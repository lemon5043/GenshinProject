using ISpan.Utility;
using Main_form.Infra.Extensions;
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

namespace Main_form.Forms.Template
{
	public partial class UploadTemplateForm : Form
	{
		public UploadTemplateForm()
		{
			InitializeComponent();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog()
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
				Filter = "Image Files Only (*.jpg, *.gif, *.png, *.bmp) | *.jpg; *.gif; *.png; *.bmp",
				Multiselect = false
			})
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					//display image to picturebox
					pictureBox1.Image = Image.FromFile(ofd.FileName);
					//set path
					txtFileName.Text = ofd.SafeFileName;
				}
		}

		private void btnUploadImage_Click(object sender, EventArgs e)
		{
			try
			{
				if (pictureBox1.Image == null) return;

				// 取得表單的各欄位值
				string template_name = txtFileName.Text;
				byte[] photo = pictureBox1.Image.ConvertImageToBytes();

				// 將它們繫結到ViewModel
				TemplateVM model = new TemplateVM
				{
					Template_Name = template_name,
					Photo = photo,
				};

				// 針對ViewModel進行欄位驗證
				string errorMsg = string.Empty;
				if (string.IsNullOrEmpty(model.Template_Name)) errorMsg += "You need to name your photo\r\n";
				//if (model.ListPrice < 0) errorMsg += "牌價必需輸入大於或等於零的整數\r\n";

				if (string.IsNullOrEmpty(errorMsg) == false)
				{
					//表示至少一欄有錯誤
					MessageBox.Show(errorMsg);
					return; // 不再向下執行
				}


				// 如果通過驗證,就新增記錄
				string sql = @"INSERT INTO template
									(template_name, photo)
									VALUES
									(@template_name, @photo)";

				var parameters = new SqlParameterBuilder()
					.AddNVarchar("template_name", 50, model.Template_Name)
					.AddByte("photo", model.Photo)
					.Build();



				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

				MessageBox.Show("上傳成功");
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error!, Couldn't load the file" + ex.Message);
			}
		}
	}
}
