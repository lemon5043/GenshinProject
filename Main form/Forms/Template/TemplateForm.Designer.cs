namespace Main_form
{
	partial class TemplateForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnUploadImage = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Template_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.operationPanel = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDownload = new System.Windows.Forms.Button();
			this.label123 = new System.Windows.Forms.Label();
			this.btnMakeMeme = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.btnDelete = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.templateVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.templateVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.templateFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.operationPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.templateVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.templateVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.templateFormBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUploadImage
			// 
			this.btnUploadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(111)))));
			this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUploadImage.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUploadImage.ForeColor = System.Drawing.Color.White;
			this.btnUploadImage.Location = new System.Drawing.Point(1136, 14);
			this.btnUploadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUploadImage.Name = "btnUploadImage";
			this.btnUploadImage.Size = new System.Drawing.Size(115, 41);
			this.btnUploadImage.TabIndex = 5;
			this.btnUploadImage.Text = "Upload";
			this.btnUploadImage.UseVisualStyleBackColor = false;
			this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(464, 110);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(565, 449);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Template_Name});
			this.dataGridView1.DataSource = this.templateVMBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(56, 91);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(142, 492);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// Template_Name
			// 
			this.Template_Name.DataPropertyName = "Template_Name";
			this.Template_Name.HeaderText = "素材名";
			this.Template_Name.MinimumWidth = 6;
			this.Template_Name.Name = "Template_Name";
			this.Template_Name.ReadOnly = true;
			// 
			// operationPanel
			// 
			this.operationPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.operationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.operationPanel.Controls.Add(this.btnDelete);
			this.operationPanel.Controls.Add(this.label2);
			this.operationPanel.Controls.Add(this.label1);
			this.operationPanel.Controls.Add(this.btnDownload);
			this.operationPanel.Controls.Add(this.label123);
			this.operationPanel.Controls.Add(this.btnMakeMeme);
			this.operationPanel.Controls.Add(this.dataGridView1);
			this.operationPanel.Controls.Add(this.pictureBox1);
			this.operationPanel.Controls.Add(this.btnUploadImage);
			this.operationPanel.Location = new System.Drawing.Point(0, -4);
			this.operationPanel.Margin = new System.Windows.Forms.Padding(0);
			this.operationPanel.Name = "operationPanel";
			this.operationPanel.Size = new System.Drawing.Size(1256, 680);
			this.operationPanel.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(26, 46);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 25);
			this.label2.TabIndex = 11;
			this.label2.Text = "選擇你想要的素材";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(921, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 25);
			this.label1.TabIndex = 10;
			this.label1.Text = "沒有想要的素材嗎?";
			// 
			// btnDownload
			// 
			this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(111)))));
			this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDownload.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDownload.ForeColor = System.Drawing.Color.White;
			this.btnDownload.Location = new System.Drawing.Point(464, 604);
			this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(171, 44);
			this.btnDownload.TabIndex = 9;
			this.btnDownload.Text = "Download";
			this.btnDownload.UseVisualStyleBackColor = false;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// label123
			// 
			this.label123.AutoSize = true;
			this.label123.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.label123.Location = new System.Drawing.Point(1191, 662);
			this.label123.Name = "label123";
			this.label123.Size = new System.Drawing.Size(55, 15);
			this.label123.TabIndex = 8;
			this.label123.Text = "label123";
			// 
			// btnMakeMeme
			// 
			this.btnMakeMeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(63)))), ((int)(((byte)(111)))));
			this.btnMakeMeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMakeMeme.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMakeMeme.ForeColor = System.Drawing.Color.White;
			this.btnMakeMeme.Location = new System.Drawing.Point(860, 604);
			this.btnMakeMeme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMakeMeme.Name = "btnMakeMeme";
			this.btnMakeMeme.Size = new System.Drawing.Size(169, 44);
			this.btnMakeMeme.TabIndex = 7;
			this.btnMakeMeme.Text = "Use this!";
			this.btnMakeMeme.UseVisualStyleBackColor = false;
			this.btnMakeMeme.Click += new System.EventHandler(this.btnMakeMeme_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(1184, 649);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(69, 28);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// templateVMBindingSource1
			// 
			this.templateVMBindingSource1.DataSource = typeof(Main_form.models.viewmodels.TemplateVM);
			// 
			// templateVMBindingSource
			// 
			this.templateVMBindingSource.DataSource = typeof(Main_form.models.viewmodels.TemplateVM);
			// 
			// templateFormBindingSource
			// 
			this.templateFormBindingSource.DataSource = typeof(Main_form.TemplateForm);
			// 
			// TemplateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(1265, 685);
			this.Controls.Add(this.operationPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TemplateForm";
			this.Text = "CharacterForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.operationPanel.ResumeLayout(false);
			this.operationPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.templateVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.templateVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.templateFormBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource templateVMBindingSource;
		private System.Windows.Forms.Button btnUploadImage;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel operationPanel;
		private System.Windows.Forms.Button btnMakeMeme;
		private System.Windows.Forms.BindingSource templateFormBindingSource;
		private System.Windows.Forms.BindingSource templateVMBindingSource1;
		private System.Windows.Forms.Label label123;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Template_Name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDelete;
	}
}