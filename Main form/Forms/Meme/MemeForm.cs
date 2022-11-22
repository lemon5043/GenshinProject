using ISpan.Utility;
using Main_form.Forms.Meme;
using Main_form.Forms.Template;
using Main_form.Infra.Extensions;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Main_form
{
	public partial class MemeForm : Form

	{
		public MemeForm()
		{
			InitializeComponent();
			SetUpApp();
		}

		public MemeForm(int id)
		{
			InitializeComponent();
			SetUpApp();

			string sql = "SELECT photo FROM template WHERE id=@id";
			var parameters = new SqlParameterBuilder()
				.AddInt("id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			DataRow rows = data.Rows[0];

			imgPreview.Image = rows.Field<byte[]>("photo").ConvertByteArrayToImage();
			label123.Text = id.ToString();
		}

		private void SetUpApp()
		{
			imgPreview.Controls.Add(txtTopPreviewText);
			imgPreview.Controls.Add(txtBottomPreviewText);

			txtTopPreviewText.Location = new Point(0, 0);

			txtBottomPreviewText.Location = new Point(0, 180);

			imgPreview.SendToBack();

		}

		private void ChangeTextColor(object sender, EventArgs e)
		{
			Button tempButton = sender as Button;

			txtTopPreviewText.ForeColor = tempButton.BackColor;
			txtBottomPreviewText.ForeColor = tempButton.BackColor;
		}

		//更改上下圖片文字
		private void txtTop_TextChanged(object sender, EventArgs e)
		{
			txtTopPreviewText.Text = txtTop.Text;
		}

		private void txtBottom_TextChanged(object sender, EventArgs e)
		{
			txtBottomPreviewText.Text = txtBottom.Text;
		}

		private void btnDownload_Click(object sender, EventArgs e)
		{
			if(imgPreview.Image == null) return;
			SaveFileDialog saveDialog = new SaveFileDialog();

			saveDialog.FileName = "Made meme by yourself!";
			saveDialog.DefaultExt = "jpg";
			saveDialog.Filter = "JPG Image | *.jpg";
			saveDialog.ValidateNames = true;

			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				int width = Convert.ToInt32(imgPreview.Width);
				int height = Convert.ToInt32(imgPreview.Height);
				Bitmap bmp = new Bitmap(width, height);
				imgPreview.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
				bmp.Save(saveDialog.FileName, ImageFormat.Jpeg);
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			panel1.Controls.Clear();
			panel1.LoadForm(new TemplateForm());
		}

		private void btnShare_Click(object sender, EventArgs e)
		{
			if (imgPreview.Image == null) return;

			int width = Convert.ToInt32(imgPreview.Width);
			int height = Convert.ToInt32(imgPreview.Height);
			Bitmap bmp = new Bitmap(width, height);
			imgPreview.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

			var frm = new UploadMemeForm(label123.Text.ToInt(-1), bmp);

			if (frm.ShowDialog() == DialogResult.OK)
			{
			}

		}
	}
}
