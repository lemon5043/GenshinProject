namespace Main_form
{
	partial class AdminForm
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
			this.btnManageUser = new System.Windows.Forms.Button();
			this.optionPanel = new System.Windows.Forms.Panel();
			this.btnMagageTemplate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnManageMeme = new System.Windows.Forms.Button();
			this.operationPanel = new System.Windows.Forms.Panel();
			this.optionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnManageUser
			// 
			this.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManageUser.ForeColor = System.Drawing.Color.White;
			this.btnManageUser.Location = new System.Drawing.Point(12, 68);
			this.btnManageUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnManageUser.Name = "btnManageUser";
			this.btnManageUser.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnManageUser.Size = new System.Drawing.Size(313, 63);
			this.btnManageUser.TabIndex = 1;
			this.btnManageUser.Text = "User";
			this.btnManageUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnManageUser.UseVisualStyleBackColor = true;
			this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
			// 
			// optionPanel
			// 
			this.optionPanel.Controls.Add(this.btnMagageTemplate);
			this.optionPanel.Controls.Add(this.label1);
			this.optionPanel.Controls.Add(this.btnManageMeme);
			this.optionPanel.Controls.Add(this.btnManageUser);
			this.optionPanel.Location = new System.Drawing.Point(0, 0);
			this.optionPanel.Margin = new System.Windows.Forms.Padding(0);
			this.optionPanel.Name = "optionPanel";
			this.optionPanel.Size = new System.Drawing.Size(333, 861);
			this.optionPanel.TabIndex = 2;
			// 
			// btnMagageTemplate
			// 
			this.btnMagageTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMagageTemplate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMagageTemplate.ForeColor = System.Drawing.Color.White;
			this.btnMagageTemplate.Location = new System.Drawing.Point(12, 204);
			this.btnMagageTemplate.Margin = new System.Windows.Forms.Padding(4);
			this.btnMagageTemplate.Name = "btnMagageTemplate";
			this.btnMagageTemplate.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnMagageTemplate.Size = new System.Drawing.Size(313, 63);
			this.btnMagageTemplate.TabIndex = 4;
			this.btnMagageTemplate.Text = "Template";
			this.btnMagageTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMagageTemplate.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Magagement";
			// 
			// btnManageMeme
			// 
			this.btnManageMeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageMeme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManageMeme.ForeColor = System.Drawing.Color.White;
			this.btnManageMeme.Location = new System.Drawing.Point(12, 135);
			this.btnManageMeme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnManageMeme.Name = "btnManageMeme";
			this.btnManageMeme.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
			this.btnManageMeme.Size = new System.Drawing.Size(313, 63);
			this.btnManageMeme.TabIndex = 2;
			this.btnManageMeme.Text = "Meme";
			this.btnManageMeme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnManageMeme.UseVisualStyleBackColor = true;
			this.btnManageMeme.Click += new System.EventHandler(this.btnManageMeme_Click);
			// 
			// operationPanel
			// 
			this.operationPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.operationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.operationPanel.Location = new System.Drawing.Point(333, 0);
			this.operationPanel.Margin = new System.Windows.Forms.Padding(0);
			this.operationPanel.Name = "operationPanel";
			this.operationPanel.Size = new System.Drawing.Size(1267, 861);
			this.operationPanel.TabIndex = 3;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
			this.ClientSize = new System.Drawing.Size(1280, 700);
			this.Controls.Add(this.operationPanel);
			this.Controls.Add(this.optionPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "AdminForm";
			this.Text = "AdminForm";
			this.optionPanel.ResumeLayout(false);
			this.optionPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnManageUser;
		private System.Windows.Forms.Panel optionPanel;
		private System.Windows.Forms.Panel operationPanel;
		private System.Windows.Forms.Button btnManageMeme;
		private System.Windows.Forms.Button btnMagageTemplate;
		private System.Windows.Forms.Label label1;
	}
}