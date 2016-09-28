using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ftpOperation
{
    public partial class Form1 : Form
    {
        FileTransferProtocol testExample;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if (txt_username.Text != "" && txt_password.Text != "")
            {
                if (txt_destinationPath.Text != "" && txt_sourcePath.Text != "")
                {
                    testExample = new FileTransferProtocol(txt_username.Text, txt_password.Text);

                    bool operationFlag = testExample.ftpFileDownload(txt_sourcePath.Text, txt_destinationPath.Text);

                    if (operationFlag == true)
                    {
                        MessageBox.Show("Transfer completed.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Transfer failed.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Paths cannot be left blank.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Login information cannot be left blank.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (txt_username.Text != "" && txt_password.Text != "")
            {
                if (txt_destinationPath.Text != "" && txt_sourcePath.Text != "")
                {
                    testExample = new FileTransferProtocol(txt_username.Text, txt_password.Text);

                    bool operationFlag = testExample.ftpFileUpload(txt_sourcePath.Text, txt_destinationPath.Text);

                    if (operationFlag == true)
                    {
                        MessageBox.Show("Transfer completed.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Transfer failed.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Paths cannot be left blank.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Login information cannot be left blank.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
