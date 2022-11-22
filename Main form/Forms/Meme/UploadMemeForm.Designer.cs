namespace Main_form.Forms.Meme
{
	partial class UploadMemeForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.memePicture = new System.Windows.Forms.PictureBox();
			this.txtMemeName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTemplateID = new System.Windows.Forms.Label();
			this.btnUpload = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.memePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "確定要上傳嗎?";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(182, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Here\'s your meme";
			// 
			// memePicture
			// 
			this.memePicture.Location = new System.Drawing.Point(17, 103);
			this.memePicture.Name = "memePicture";
			this.memePicture.Size = new System.Drawing.Size(461, 215);
			this.memePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.memePicture.TabIndex = 2;
			this.memePicture.TabStop = false;
			// 
			// txtMemeName
			// 
			this.txtMemeName.Location = new System.Drawing.Point(149, 347);
			this.txtMemeName.Name = "txtMemeName";
			this.txtMemeName.Size = new System.Drawing.Size(313, 25);
			this.txtMemeName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 347);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "取個名字吧:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 410);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "使用素材ID:";
			// 
			// txtTemplateID
			// 
			this.txtTemplateID.AutoSize = true;
			this.txtTemplateID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtTemplateID.ForeColor = System.Drawing.Color.White;
			this.txtTemplateID.Location = new System.Drawing.Point(136, 410);
			this.txtTemplateID.Name = "txtTemplateID";
			this.txtTemplateID.Size = new System.Drawing.Size(24, 25);
			this.txtTemplateID.TabIndex = 6;
			this.txtTemplateID.Text = "0";
			// 
			// btnUpload
			// 
			this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(111)))));
			this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpload.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpload.ForeColor = System.Drawing.Color.White;
			this.btnUpload.Location = new System.Drawing.Point(362, 398);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(100, 37);
			this.btnUpload.TabIndex = 7;
			this.btnUpload.Text = "Upload";
			this.btnUpload.UseVisualStyleBackColor = false;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// UploadMemeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(502, 461);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.txtTemplateID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtMemeName);
			this.Controls.Add(this.memePicture);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "UploadMemeForm";
			this.Text = "UploadMemeForm";
			((System.ComponentModel.ISupportInitialize)(this.memePicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox memePicture;
		private System.Windows.Forms.TextBox txtMemeName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label txtTemplateID;
		private System.Windows.Forms.Button btnUpload;
	}
}