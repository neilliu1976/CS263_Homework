namespace FeedFish
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
			this.components = new System.ComponentModel.Container();
			this.addFishRadioButton = new System.Windows.Forms.RadioButton();
			this.addFoodRadioButton = new System.Windows.Forms.RadioButton();
			this.mainTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// addFishRadioButton
			// 
			this.addFishRadioButton.BackColor = System.Drawing.Color.Gray;
			this.addFishRadioButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addFishRadioButton.ForeColor = System.Drawing.Color.Yellow;
			this.addFishRadioButton.Location = new System.Drawing.Point(12, 12);
			this.addFishRadioButton.Name = "addFishRadioButton";
			this.addFishRadioButton.Size = new System.Drawing.Size(80, 20);
			this.addFishRadioButton.TabIndex = 0;
			this.addFishRadioButton.TabStop = true;
			this.addFishRadioButton.Text = "加入魚";
			this.addFishRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.addFishRadioButton.UseVisualStyleBackColor = false;
			// 
			// addFoodRadioButton
			// 
			this.addFoodRadioButton.BackColor = System.Drawing.Color.Gray;
			this.addFoodRadioButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addFoodRadioButton.ForeColor = System.Drawing.Color.Yellow;
			this.addFoodRadioButton.Location = new System.Drawing.Point(112, 12);
			this.addFoodRadioButton.Name = "addFoodRadioButton";
			this.addFoodRadioButton.Size = new System.Drawing.Size(80, 20);
			this.addFoodRadioButton.TabIndex = 1;
			this.addFoodRadioButton.TabStop = true;
			this.addFoodRadioButton.Text = "加入餌";
			this.addFoodRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.addFoodRadioButton.UseVisualStyleBackColor = false;
			// 
			// mainTimer
			// 
			this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 571);
			this.Controls.Add(this.addFoodRadioButton);
			this.Controls.Add(this.addFishRadioButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "餵魚";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.RadioButton addFoodRadioButton;
		private System.Windows.Forms.RadioButton addFishRadioButton;
		private System.Windows.Forms.Timer mainTimer;
	}
}

