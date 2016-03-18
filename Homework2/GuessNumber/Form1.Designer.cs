namespace GuessNumber
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
            this.btnPress = new System.Windows.Forms.Button();
            this.btnGetAnswer = new System.Windows.Forms.Button();
            this.txtbInput = new System.Windows.Forms.TextBox();
            this.txtbMessage = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPress
            // 
            this.btnPress.Location = new System.Drawing.Point(12, 12);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(75, 23);
            this.btnPress.TabIndex = 0;
            this.btnPress.Text = "新局";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // btnGetAnswer
            // 
            this.btnGetAnswer.Location = new System.Drawing.Point(93, 12);
            this.btnGetAnswer.Name = "btnGetAnswer";
            this.btnGetAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnGetAnswer.TabIndex = 2;
            this.btnGetAnswer.Text = "看答案";
            this.btnGetAnswer.UseVisualStyleBackColor = true;
            this.btnGetAnswer.Click += new System.EventHandler(this.btnGetAnswer_Click);
            // 
            // txtbInput
            // 
            this.txtbInput.Location = new System.Drawing.Point(12, 41);
            this.txtbInput.MaxLength = 4;
            this.txtbInput.Name = "txtbInput";
            this.txtbInput.Size = new System.Drawing.Size(75, 22);
            this.txtbInput.TabIndex = 3;
            // 
            // txtbMessage
            // 
            this.txtbMessage.Location = new System.Drawing.Point(12, 69);
            this.txtbMessage.Multiline = true;
            this.txtbMessage.Name = "txtbMessage";
            this.txtbMessage.Size = new System.Drawing.Size(156, 188);
            this.txtbMessage.TabIndex = 4;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(93, 41);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "猜看看";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 269);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtbMessage);
            this.Controls.Add(this.txtbInput);
            this.Controls.Add(this.btnGetAnswer);
            this.Controls.Add(this.btnPress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPress;
        private System.Windows.Forms.Button btnGetAnswer;
        private System.Windows.Forms.TextBox txtbInput;
        private System.Windows.Forms.TextBox txtbMessage;
        private System.Windows.Forms.Button btnGuess;
    }
}

