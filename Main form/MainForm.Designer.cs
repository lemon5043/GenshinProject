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
			this.btnSetting = new System.Windows.Forms.Button();
			this.btnWeapen = new System.Windows.Forms.Button();
			this.btnCharacter = new System.Windows.Forms.Button();
			this.optionPanel = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.mainPanel = new System.Windows.Forms.Panel();
			this.menuPanel.SuspendLayout();
			this.optionPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPanel
			// 
			this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.menuPanel.Controls.Add(this.btnSetting);
			this.menuPanel.Controls.Add(this.btnWeapen);
			this.menuPanel.Controls.Add(this.btnCharacter);
			this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuPanel.Location = new System.Drawing.Point(0, 0);
			this.menuPanel.Margin = new System.Windows.Forms.Padding(0);
			this.menuPanel.Name = "menuPanel";
			this.menuPanel.Size = new System.Drawing.Size(107, 826);
			this.menuPanel.TabIndex = 1;
			// 
			// btnSetting
			// 
			this.btnSetting.Location = new System.Drawing.Point(0, 198);
			this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(107, 100);
			this.btnSetting.TabIndex = 2;
			this.btnSetting.Text = "setting";
			this.btnSetting.UseVisualStyleBackColor = true;
			this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
			// 
			// btnWeapen
			// 
			this.btnWeapen.Location = new System.Drawing.Point(0, 99);
			this.btnWeapen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnWeapen.Name = "btnWeapen";
			this.btnWeapen.Size = new System.Drawing.Size(107, 100);
			this.btnWeapen.TabIndex = 1;
			this.btnWeapen.Text = "weapen";
			this.btnWeapen.UseVisualStyleBackColor = true;
			this.btnWeapen.Click += new System.EventHandler(this.btnWeapen_Click);
			// 
			// btnCharacter
			// 
			this.btnCharacter.Location = new System.Drawing.Point(0, 0);
			this.btnCharacter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnCharacter.Name = "btnCharacter";
			this.btnCharacter.Size = new System.Drawing.Size(107, 100);
			this.btnCharacter.TabIndex = 0;
			this.btnCharacter.Text = "character";
			this.btnCharacter.UseVisualStyleBackColor = true;
			this.btnCharacter.Click += new System.EventHandler(this.btnCharacter_Click);
			// 
			// optionPanel
			// 
			this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
			this.optionPanel.Controls.Add(this.button1);
			this.optionPanel.Controls.Add(this.textBox1);
			this.optionPanel.Location = new System.Drawing.Point(107, 0);
			this.optionPanel.Margin = new System.Windows.Forms.Padding(0);
			this.optionPanel.Name = "optionPanel";
			this.optionPanel.Size = new System.Drawing.Size(533, 826);
			this.optionPanel.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(317, 15);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 29);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(37, 15);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(237, 25);
			this.textBox1.TabIndex = 0;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1685, 826);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.optionPanel);
			this.Controls.Add(this.menuPanel);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.menuPanel.ResumeLayout(false);
			this.optionPanel.ResumeLayout(false);
			this.optionPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel menuPanel;
		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.Button btnWeapen;
		private System.Windows.Forms.Button btnCharacter;
		private System.Windows.Forms.Panel optionPanel;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
	}
}

