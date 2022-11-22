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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mainPanel = new System.Windows.Forms.Panel();
			this.btnTemplate = new System.Windows.Forms.Button();
			this.btnPhoto = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.menuPanel = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.mainPanel.Location = new System.Drawing.Point(80, 0);
			this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1184, 689);
			this.mainPanel.TabIndex = 3;
			// 
			// btnTemplate
			// 
			this.btnTemplate.BackColor = System.Drawing.Color.Transparent;
			this.btnTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btnTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btnTemplate.Image")));
			this.btnTemplate.Location = new System.Drawing.Point(0, 136);
			this.btnTemplate.Margin = new System.Windows.Forms.Padding(0);
			this.btnTemplate.Name = "btnTemplate";
			this.btnTemplate.Size = new System.Drawing.Size(80, 80);
			this.btnTemplate.TabIndex = 0;
			this.btnTemplate.UseVisualStyleBackColor = false;
			this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
			// 
			// btnPhoto
			// 
			this.btnPhoto.BackColor = System.Drawing.Color.Transparent;
			this.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btnPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnPhoto.Image")));
			this.btnPhoto.Location = new System.Drawing.Point(0, 220);
			this.btnPhoto.Margin = new System.Windows.Forms.Padding(4);
			this.btnPhoto.Name = "btnPhoto";
			this.btnPhoto.Size = new System.Drawing.Size(80, 80);
			this.btnPhoto.TabIndex = 1;
			this.btnPhoto.UseVisualStyleBackColor = false;
			this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
			// 
			// btnUser
			// 
			this.btnUser.BackColor = System.Drawing.Color.Transparent;
			this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
			this.btnUser.Location = new System.Drawing.Point(0, 308);
			this.btnUser.Margin = new System.Windows.Forms.Padding(4);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(80, 80);
			this.btnUser.TabIndex = 2;
			this.btnUser.UseVisualStyleBackColor = false;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.menuPanel.Controls.Add(this.btnHome);
			this.menuPanel.Controls.Add(this.panel1);
			this.menuPanel.Controls.Add(this.btnUser);
			this.menuPanel.Controls.Add(this.btnPhoto);
			this.menuPanel.Controls.Add(this.btnTemplate);
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(80, 689);
			this.menuPanel.TabIndex = 1;
			// 
			// btnHome
			// 
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.Location = new System.Drawing.Point(0, 53);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(80, 80);
			this.btnHome.TabIndex = 5;
			this.btnHome.UseVisualStyleBackColor = true;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(80, 50);
			this.panel1.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(1264, 689);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.menuPanel);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Meme generator";
			this.menuPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button btnTemplate;
		private System.Windows.Forms.Button btnPhoto;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Panel menuPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnHome;
	}
}

