namespace Main_form
{
	partial class MainForm
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuPanel = new System.Windows.Forms.Panel();
			this.btnUser = new System.Windows.Forms.Button();
			this.btnPhoto = new System.Windows.Forms.Button();
			this.btnTemplate = new System.Windows.Forms.Button();
			this.optionPanel = new System.Windows.Forms.Panel();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.menuPanel.Controls.Add(this.btnAdmin);
			this.menuPanel.Controls.Add(this.btnUser);
			this.menuPanel.Controls.Add(this.btnPhoto);
			this.menuPanel.Controls.Add(this.btnTemplate);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(107, 826);
			this.menuPanel.TabIndex = 1;
			// 
			// btnUser
			// 
			this.btnUser.Location = new System.Drawing.Point(0, 198);
			this.btnUser.Margin = new System.Windows.Forms.Padding(4);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(107, 100);
			this.btnUser.TabIndex = 2;
			this.btnUser.Text = "User";
			this.btnUser.UseVisualStyleBackColor = true;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// btnPhoto
			// 
			this.btnPhoto.Location = new System.Drawing.Point(0, 99);
			this.btnPhoto.Margin = new System.Windows.Forms.Padding(4);
			this.btnPhoto.Name = "btnPhoto";
			this.btnPhoto.Size = new System.Drawing.Size(107, 100);
			this.btnPhoto.TabIndex = 1;
			this.btnPhoto.Text = "photo";
			this.btnPhoto.UseVisualStyleBackColor = true;
			this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
			// 
			// btnTemplate
			// 
			this.btnTemplate.Location = new System.Drawing.Point(0, 0);
			this.btnTemplate.Margin = new System.Windows.Forms.Padding(4);
			this.btnTemplate.Name = "btnTemplate";
			this.btnTemplate.Size = new System.Drawing.Size(107, 100);
			this.btnTemplate.TabIndex = 0;
			this.btnTemplate.Text = "template";
			this.btnTemplate.UseVisualStyleBackColor = true;
			this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
			// 
			// optionPanel
			// 
			this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
			this.optionPanel.Location = new System.Drawing.Point(107, 0);
			this.optionPanel.Margin = new System.Windows.Forms.Padding(0);
			this.optionPanel.Name = "optionPanel";
			this.optionPanel.Size = new System.Drawing.Size(533, 826);
			this.optionPanel.TabIndex = 2;
			// 
			// mainPanel
			// 
			this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.mainPanel.Location = new System.Drawing.Point(640, 0);
			this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1053, 826);
			this.mainPanel.TabIndex = 3;
			// 
			// btnAdmin
			// 
			this.btnAdmin.Location = new System.Drawing.Point(0, 296);
			this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(107, 100);
			this.btnAdmin.TabIndex = 3;
			this.btnAdmin.Text = "Admin";
			this.btnAdmin.UseVisualStyleBackColor = true;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1685, 826);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.optionPanel);
			this.Controls.Add(this.menuPanel);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.menuPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel menuPanel;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnPhoto;
		private System.Windows.Forms.Button btnTemplate;
		private System.Windows.Forms.Panel optionPanel;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button btnAdmin;
	}
}

