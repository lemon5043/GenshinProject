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
using System.Windows.Documents.DocumentStructures;
using System.Windows.Forms;

namespace Main_form.Forms.Meme
{
	public partial class UploadMemeForm : Form
	{
		private int id;
		private Bitmap image;
		public UploadMemeForm(int id, Bitmap image)
		{
			InitializeComponent();
			this.id = id;
			this.image = image;
			txtTemplateID.Text = id.ToString();
			memePicture.Image = image;
		}

		private void btnUpload_Click(object sender, EventArgs e)
		{
			try
			{
				if (memePicture.Image == null) return;

				// 取得表單的各欄位值
				string name = txtMemeName.Text;
				byte[] meme = memePicture.Image.ConvertImageToBytes();
				int template_id = txtTemplateID.Text.ToInt();

				// 將它們繫結到ViewModel
				MemeVM model = new MemeVM
				{
					Template_Id = template_id,
					Meme = meme,
					Name = name,
				};

				// 針對ViewModel進行欄位驗證
				string errorMsg = string.Empty;
				if (string.IsNullOrEmpty(model.Name)) errorMsg += "You need to name your photo\r\n";
				//if (model.ListPrice < 0) errorMsg += "牌價必需輸入大於或等於零的整數\r\n";

				if (string.IsNullOrEmpty(errorMsg) == false)
				{
					//表示至少一欄有錯誤
					MessageBox.Show(errorMsg);
					return; // 不再向下執行
				}


				// 如果通過驗證,就新增記錄
				string sql = @"INSERT INTO meme
									(Template_Id, Name, Meme)
									VALUES
									(@Template_Id, @Name, @Meme)";

				var parameters = new SqlParameterBuilder()
					.AddInt("Template_Id", template_id)
					.AddByte("meme", model.Meme)
					.AddNVarchar("Name", 50, name)
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
