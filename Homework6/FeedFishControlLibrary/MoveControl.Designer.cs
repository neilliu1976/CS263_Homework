namespace FeedFishControlLibrary
{
	partial class MoveControl
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

		#region 元件設計工具產生的程式碼

		/// <summary> 
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.textLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.actionTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// textLabel
			// 
			this.textLabel.Location = new System.Drawing.Point(0, 0);
			this.textLabel.Name = "textLabel";
			this.textLabel.Size = new System.Drawing.Size(100, 14);
			this.textLabel.TabIndex = 0;
			this.textLabel.Text = "label1";
			this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nameLabel
			// 
			this.nameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.nameLabel.Location = new System.Drawing.Point(0, 14);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(100, 20);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "label1";
			this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// actionTimer
			// 
			this.actionTimer.Tick += new System.EventHandler(this.actionTimer_Tick);
			// 
			// MoveControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.textLabel);
			this.Name = "MoveControl";
			this.Size = new System.Drawing.Size(100, 34);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label textLabel;
		private System.Windows.Forms.Label nameLabel;
		public System.Windows.Forms.Timer actionTimer;
	}
}
