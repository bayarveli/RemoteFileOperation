using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteFileOperation
{
    public partial class Form1 : Form
    {
        RemoteDesktopOperation testExample;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            if (txt_username.Text != "" && txt_password.Text != "" && txt_pcName.Text != "")
            {
                if (txt_destinationPath.Text != "" && txt_sourcePath.Text != "")
                {
                    testExample = new RemoteDesktopOperation(txt_username.Text, txt_password.Text, txt_pcName.Text);

                    bool operationFlag = testExample.fileTransfer(txt_sourcePath.Text, txt_destinationPath.Text);

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
