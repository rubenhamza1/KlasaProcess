namespace KlasaProces
{
    partial class Form1
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
            this.btnInternetExplorer = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnStartInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInternetExplorer
            // 
            this.btnInternetExplorer.Location = new System.Drawing.Point(36, 40);
            this.btnInternetExplorer.Name = "btnInternetExplorer";
            this.btnInternetExplorer.Size = new System.Drawing.Size(113, 26);
            this.btnInternetExplorer.TabIndex = 0;
            this.btnInternetExplorer.Text = "Internet Explorer";
            this.btnInternetExplorer.UseVisualStyleBackColor = true;
            this.btnInternetExplorer.Click += new System.EventHandler(this.btnInternetExplorer_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(168, 40);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(119, 26);
            this.btnWord.TabIndex = 1;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(36, 97);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(113, 23);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnStartInfo
            // 
            this.btnStartInfo.Location = new System.Drawing.Point(168, 97);
            this.btnStartInfo.Name = "btnStartInfo";
            this.btnStartInfo.Size = new System.Drawing.Size(119, 23);
            this.btnStartInfo.TabIndex = 3;
            this.btnStartInfo.Text = "StartInfo";
            this.btnStartInfo.UseVisualStyleBackColor = true;
            this.btnStartInfo.Click += new System.EventHandler(this.btnStartInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 174);
            this.Controls.Add(this.btnStartInfo);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.btnInternetExplorer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInternetExplorer;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnStartInfo;
    }
}

