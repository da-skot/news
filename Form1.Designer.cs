namespace laba_7_8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DownloadRSS = new System.Windows.Forms.Button();
            this.UploadDB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DownloadBD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DownloadRSS
            // 
            this.DownloadRSS.Location = new System.Drawing.Point(6, 483);
            this.DownloadRSS.Name = "DownloadRSS";
            this.DownloadRSS.Size = new System.Drawing.Size(107, 23);
            this.DownloadRSS.TabIndex = 0;
            this.DownloadRSS.Text = "Загрузить RSS";
            this.DownloadRSS.UseVisualStyleBackColor = true;
            this.DownloadRSS.Click += new System.EventHandler(this.DownloadRSS_Click);
            // 
            // UploadDB
            // 
            this.UploadDB.Location = new System.Drawing.Point(484, 492);
            this.UploadDB.Name = "UploadDB";
            this.UploadDB.Size = new System.Drawing.Size(128, 23);
            this.UploadDB.TabIndex = 1;
            this.UploadDB.Text = "Записать в БД";
            this.UploadDB.UseVisualStyleBackColor = true;
            this.UploadDB.Click += new System.EventHandler(this.UploadDB_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 483);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 19);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(445, 458);
            this.webBrowser1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.DownloadRSS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 512);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WebBrowser";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(484, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(447, 474);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // DownloadBD
            // 
            this.DownloadBD.Location = new System.Drawing.Point(618, 492);
            this.DownloadBD.Name = "DownloadBD";
            this.DownloadBD.Size = new System.Drawing.Size(128, 23);
            this.DownloadBD.TabIndex = 6;
            this.DownloadBD.Text = "Загрузить из БД";
            this.DownloadBD.UseVisualStyleBackColor = true;
            this.DownloadBD.Click += new System.EventHandler(this.DownloadBD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 536);
            this.Controls.Add(this.DownloadBD);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UploadDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DownloadRSS;
        private System.Windows.Forms.Button UploadDB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button DownloadBD;
    }
}

