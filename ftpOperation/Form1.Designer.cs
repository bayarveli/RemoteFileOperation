namespace ftpOperation
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
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.lbl_destinationPath = new System.Windows.Forms.Label();
            this.txt_destinationPath = new System.Windows.Forms.TextBox();
            this.lbl_sourcePath = new System.Windows.Forms.Label();
            this.txt_sourcePath = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password.Location = new System.Drawing.Point(9, 38);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(92, 13);
            this.lbl_password.TabIndex = 19;
            this.lbl_password.Text = "FTP Password:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(130, 38);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(151, 20);
            this.txt_password.TabIndex = 18;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_username.Location = new System.Drawing.Point(9, 12);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(94, 13);
            this.lbl_username.TabIndex = 17;
            this.lbl_username.Text = "FTP Username:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(130, 12);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(151, 20);
            this.txt_username.TabIndex = 16;
            this.txt_username.UseSystemPasswordChar = true;
            // 
            // btn_download
            // 
            this.btn_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_download.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_download.Location = new System.Drawing.Point(209, 112);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(140, 43);
            this.btn_download.TabIndex = 15;
            this.btn_download.Text = "DOWNLOAD";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // lbl_destinationPath
            // 
            this.lbl_destinationPath.AutoSize = true;
            this.lbl_destinationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_destinationPath.Location = new System.Drawing.Point(9, 164);
            this.lbl_destinationPath.Name = "lbl_destinationPath";
            this.lbl_destinationPath.Size = new System.Drawing.Size(105, 13);
            this.lbl_destinationPath.TabIndex = 14;
            this.lbl_destinationPath.Text = "Destination Path:";
            // 
            // txt_destinationPath
            // 
            this.txt_destinationPath.Location = new System.Drawing.Point(130, 161);
            this.txt_destinationPath.Name = "txt_destinationPath";
            this.txt_destinationPath.Size = new System.Drawing.Size(548, 20);
            this.txt_destinationPath.TabIndex = 13;
            // 
            // lbl_sourcePath
            // 
            this.lbl_sourcePath.AutoSize = true;
            this.lbl_sourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sourcePath.Location = new System.Drawing.Point(9, 89);
            this.lbl_sourcePath.Name = "lbl_sourcePath";
            this.lbl_sourcePath.Size = new System.Drawing.Size(81, 13);
            this.lbl_sourcePath.TabIndex = 12;
            this.lbl_sourcePath.Text = "Source Path:";
            // 
            // txt_sourcePath
            // 
            this.txt_sourcePath.Location = new System.Drawing.Point(130, 86);
            this.txt_sourcePath.Name = "txt_sourcePath";
            this.txt_sourcePath.Size = new System.Drawing.Size(548, 20);
            this.txt_sourcePath.TabIndex = 11;
            // 
            // btn_upload
            // 
            this.btn_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_upload.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_upload.Location = new System.Drawing.Point(355, 112);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(140, 43);
            this.btn_upload.TabIndex = 20;
            this.btn_upload.Text = "UPLOAD";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 190);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.lbl_destinationPath);
            this.Controls.Add(this.txt_destinationPath);
            this.Controls.Add(this.lbl_sourcePath);
            this.Controls.Add(this.txt_sourcePath);
            this.Name = "Form1";
            this.Text = "FTP File Transfer Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Label lbl_destinationPath;
        private System.Windows.Forms.TextBox txt_destinationPath;
        private System.Windows.Forms.Label lbl_sourcePath;
        private System.Windows.Forms.TextBox txt_sourcePath;
        private System.Windows.Forms.Button btn_upload;
    }
}

