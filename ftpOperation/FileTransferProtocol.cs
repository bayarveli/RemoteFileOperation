using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ftpOperation
{
    class FileTransferProtocol
    {
        private string ftpUsername;
        private string ftpPassword;

        public FileTransferProtocol(string _ftpUsername, string _ftpPassword)
        {
            this.ftpUsername = _ftpUsername;
            this.ftpPassword = _ftpPassword;
        }

        public bool ftpFileDownload(string _sourcePath, string _destinationPath)
        {
            FtpWebRequest ftpRequest = null;
            FtpWebResponse ftpResponse = null;
            Stream ftpStream = null;
            int bufferSize = 2048;

            bool operationFlag = false;

            try
            {
                /* Create an FTP Request */
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(_sourcePath);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(this.ftpUsername, this.ftpPassword);
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                /* Establish Return Communication with the FTP Server */
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Get the FTP Server's Response Stream */
                ftpStream = ftpResponse.GetResponseStream();


                /* Open a File Stream to Write the Downloaded File */
                FileStream localFileStream = new FileStream(_destinationPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                /* Buffer for the Downloaded Data */
                byte[] byteBuffer = new byte[bufferSize];
                int bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                /* Download the File by Writing the Buffered Data Until the Transfer is Complete */
                try
                {
                    while (bytesRead > 0)
                    {
                        localFileStream.Write(byteBuffer, 0, bytesRead);
                        bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                    }

                    operationFlag = true;
                }
                catch (Exception ex) 
                {
                    operationFlag = false;
                    Console.WriteLine(ex.ToString()); 
                }
                /* Resource Cleanup */
                localFileStream.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;

            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString()); 
            }

            return operationFlag;
        }

        public bool ftpFileUpload(string _sourcePath, string _destinationPath)
        {

            bool operationFlag = false;

            try
            {
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(_destinationPath);
                ftp.Credentials = new NetworkCredential(this.ftpUsername, this.ftpPassword);

                ftp.KeepAlive = true;
                ftp.UseBinary = true;
                ftp.Method = WebRequestMethods.Ftp.UploadFile;

                FileStream fs = File.OpenRead(_sourcePath);

                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();

                Stream ftpStream = ftp.GetRequestStream();
                ftpStream.Write(buffer, 0, buffer.Length);
                ftpStream.Close();

                operationFlag = true;
            }
            catch (Exception ex)
            {
                operationFlag = false;
                throw ex;
            }

            return operationFlag;
        }
    }
}
