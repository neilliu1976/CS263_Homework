namespace MovieTicketSystem
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
			this.ticketComboBox = new System.Windows.Forms.ComboBox();
			this.addButton = new System.Windows.Forms.Button();
			this.ticketLabel = new System.Windows.Forms.Label();
			this.DiscountLabel = new System.Windows.Forms.Label();
			this.discountComboBox = new System.Windows.Forms.ComboBox();
			this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
			this.countLabel = new System.Windows.Forms.Label();
			this.countTextBox = new System.Windows.Forms.TextBox();
			this.vipLabel = new System.Windows.Forms.Label();
			this.vipComboBox = new System.Windows.Forms.ComboBox();
			this.totalButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ticketComboBox
			// 
			this.ticketComboBox.FormattingEnabled = true;
			this.ticketComboBox.Location = new System.Drawing.Point(50, 12);
			this.ticketComboBox.Name = "ticketComboBox";
			this.ticketComboBox.Size = new System.Drawing.Size(121, 20);
			this.ticketComboBox.TabIndex = 0;
			this.ticketComboBox.SelectedIndexChanged += new System.EventHandler(this.ticketComboBox_SelectedIndexChanged);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(204, 10);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "加入";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// ticketLabel
			// 
			this.ticketLabel.AutoSize = true;
			this.ticketLabel.Location = new System.Drawing.Point(12, 15);
			this.ticketLabel.Name = "ticketLabel";
			this.ticketLabel.Size = new System.Drawing.Size(32, 12);
			this.ticketLabel.TabIndex = 2;
			this.ticketLabel.Text = "票種:";
			// 
			// DiscountLabel
			// 
			this.DiscountLabel.AutoSize = true;
			this.DiscountLabel.Location = new System.Drawing.Point(12, 41);
			this.DiscountLabel.Name = "DiscountLabel";
			this.DiscountLabel.Size = new System.Drawing.Size(32, 12);
			this.DiscountLabel.TabIndex = 3;
			this.DiscountLabel.Text = "折扣:";
			// 
			// discountComboBox
			// 
			this.discountComboBox.FormattingEnabled = true;
			this.discountComboBox.Location = new System.Drawing.Point(50, 38);
			this.discountComboBox.Name = "discountComboBox";
			this.discountComboBox.Size = new System.Drawing.Size(121, 20);
			this.discountComboBox.TabIndex = 4;
			// 
			// messageRichTextBox
			// 
			this.messageRichTextBox.Location = new System.Drawing.Point(14, 118);
			this.messageRichTextBox.Name = "messageRichTextBox";
			this.messageRichTextBox.Size = new System.Drawing.Size(265, 137);
			this.messageRichTextBox.TabIndex = 5;
			this.messageRichTextBox.Text = "";
			// 
			// countLabel
			// 
			this.countLabel.AutoSize = true;
			this.countLabel.Location = new System.Drawing.Point(12, 69);
			this.countLabel.Name = "countLabel";
			this.countLabel.Size = new System.Drawing.Size(32, 12);
			this.countLabel.TabIndex = 6;
			this.countLabel.Text = "張數:";
			// 
			// countTextBox
			// 
			this.countTextBox.Location = new System.Drawing.Point(50, 64);
			this.countTextBox.Name = "countTextBox";
			this.countTextBox.Size = new System.Drawing.Size(121, 22);
			this.countTextBox.TabIndex = 7;
			this.countTextBox.Text = "0";
			// 
			// vipLabel
			// 
			this.vipLabel.AutoSize = true;
			this.vipLabel.Location = new System.Drawing.Point(12, 95);
			this.vipLabel.Name = "vipLabel";
			this.vipLabel.Size = new System.Drawing.Size(26, 12);
			this.vipLabel.TabIndex = 8;
			this.vipLabel.Text = "VIP:";
			// 
			// vipComboBox
			// 
			this.vipComboBox.FormattingEnabled = true;
			this.vipComboBox.Location = new System.Drawing.Point(50, 92);
			this.vipComboBox.Name = "vipComboBox";
			this.vipComboBox.Size = new System.Drawing.Size(121, 20);
			this.vipComboBox.TabIndex = 9;
			// 
			// totalButton
			// 
			this.totalButton.Location = new System.Drawing.Point(204, 89);
			this.totalButton.Name = "totalButton";
			this.totalButton.Size = new System.Drawing.Size(75, 23);
			this.totalButton.TabIndex = 10;
			this.totalButton.Text = "總計";
			this.totalButton.UseVisualStyleBackColor = true;
			this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 269);
			this.Controls.Add(this.totalButton);
			this.Controls.Add(this.vipComboBox);
			this.Controls.Add(this.vipLabel);
			this.Controls.Add(this.countTextBox);
			this.Controls.Add(this.countLabel);
			this.Controls.Add(this.messageRichTextBox);
			this.Controls.Add(this.discountComboBox);
			this.Controls.Add(this.DiscountLabel);
			this.Controls.Add(this.ticketLabel);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.ticketComboBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox ticketComboBox;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Label ticketLabel;
		private System.Windows.Forms.Label DiscountLabel;
		private System.Windows.Forms.ComboBox discountComboBox;
		private System.Windows.Forms.RichTextBox messageRichTextBox;
		private System.Windows.Forms.Label countLabel;
		private System.Windows.Forms.TextBox countTextBox;
		private System.Windows.Forms.Label vipLabel;
		private System.Windows.Forms.ComboBox vipComboBox;
		private System.Windows.Forms.Button totalButton;
	}
}

