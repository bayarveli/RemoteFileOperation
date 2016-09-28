namespace RemoteFileOperation
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
            this.txt_sourcePath = new System.Windows.Forms.TextBox();
            this.lbl_sourcePath = new System.Windows.Forms.Label();
            this.lbl_destinationPath = new System.Windows.Forms.Label();
            this.txt_destinationPath = new System.Windows.Forms.TextBox();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_pcName = new System.Windows.Forms.Label();
            this.txt_pcName = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // txt_sourcePath
            // 
            this.txt_sourcePath.Location = new System.Drawing.Point(135, 127);
            this.txt_sourcePath.Name = "txt_sourcePath";
            this.txt_sourcePath.Size = new System.Drawing.Size(548, 20);
            this.txt_sourcePath.TabIndex = 0;
            // 
            // lbl_sourcePath
            // 
            this.lbl_sourcePath.AutoSize = true;
            this.lbl_sourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sourcePath.Location = new System.Drawing.Point(14, 130);
            this.lbl_sourcePath.Name = "lbl_sourcePath";
            this.lbl_sourcePath.Size = new System.Drawing.Size(81, 13);
            this.lbl_sourcePath.TabIndex = 1;
            this.lbl_sourcePath.Text = "Source Path:";
            // 
            // lbl_destinationPath
            // 
            this.lbl_destinationPath.AutoSize = true;
            this.lbl_destinationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_destinationPath.Location = new System.Drawing.Point(14, 205);
            this.lbl_destinationPath.Name = "lbl_destinationPath";
            this.lbl_destinationPath.Size = new System.Drawing.Size(105, 13);
            this.lbl_destinationPath.TabIndex = 3;
            this.lbl_destinationPath.Text = "Destination Path:";
            // 
            // txt_destinationPath
            // 
            this.txt_destinationPath.Location = new System.Drawing.Point(135, 202);
            this.txt_destinationPath.Name = "txt_destinationPath";
            this.txt_destinationPath.Size = new System.Drawing.Size(548, 20);
            this.txt_destinationPath.TabIndex = 2;
            // 
            // btn_transfer
            // 
            this.btn_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_transfer.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_transfer.Location = new System.Drawing.Point(299, 153);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(140, 43);
            this.btn_transfer.TabIndex = 4;
            this.btn_transfer.Text = "TRANSFER FILE";
            this.btn_transfer.UseVisualStyleBackColor = true;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(135, 12);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(151, 20);
            this.txt_username.TabIndex = 5;
            this.txt_username.UseSystemPasswordChar = true;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_username.Location = new System.Drawing.Point(14, 12);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(67, 13);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password.Location = new System.Drawing.Point(14, 38);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(65, 13);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(135, 38);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(151, 20);
            this.txt_password.TabIndex = 7;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_pcName
            // 
            this.lbl_pcName.AutoSize = true;
            this.lbl_pcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pcName.Location = new System.Drawing.Point(14, 64);
            this.lbl_pcName.Name = "lbl_pcName";
            this.lbl_pcName.Size = new System.Drawing.Size(63, 13);
            this.lbl_pcName.TabIndex = 10;
            this.lbl_pcName.Text = "PC Name:";
            // 
            // txt_pcName
            // 
            this.txt_pcName.Location = new System.Drawing.Point(135, 64);
            this.txt_pcName.Name = "txt_pcName";
            this.txt_pcName.Size = new System.Drawing.Size(151, 20);
            this.txt_pcName.TabIndex = 9;
            this.txt_pcName.UseSystemPasswordChar = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(694, 234);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 23;
            this.lineShape1.X2 = 672;
            this.lineShape1.Y1 = 106;
            this.lineShape1.Y2 = 106;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 234);
            this.Controls.Add(this.lbl_pcName);
            this.Controls.Add(this.txt_pcName);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.lbl_destinationPath);
            this.Controls.Add(this.txt_destinationPath);
            this.Controls.Add(this.lbl_sourcePath);
            this.Controls.Add(this.txt_sourcePath);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Remote Desktop File Transfer Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sourcePath;
        private System.Windows.Forms.Label lbl_sourcePath;
        private System.Windows.Forms.Label lbl_destinationPath;
        private System.Windows.Forms.TextBox txt_destinationPath;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_pcName;
        private System.Windows.Forms.TextBox txt_pcName;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}

