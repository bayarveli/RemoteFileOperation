using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace RemoteFileOperation
{
    class RemoteDesktopOperation
    {

        [DllImport("advapi32.DLL", SetLastError = true)]

        public static extern int LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);
        

        private string username;
        private string password;
        private string pcName;

        public RemoteDesktopOperation(string _username, string _password, string _pcName)
        {
            this.username = _username;
            this.password = _password;
            this.pcName = _pcName;
        }


        public bool fileTransfer(string _sourcePath, string _destinationPath)
        {
            bool operationFlag = true;

            IntPtr admin_token = default(IntPtr);
            WindowsIdentity wid_current = WindowsIdentity.GetCurrent();
            WindowsIdentity wid_admin = null;
            WindowsImpersonationContext wic = null;

            try
            {
                if (LogonUser(this.username, this.pcName, this.password, 9, 0, ref admin_token) != 0)
                {
                    
                    wid_admin = new WindowsIdentity(admin_token);
                    wic = wid_admin.Impersonate();

                    System.IO.File.Copy(_sourcePath, _destinationPath, true);

                }
                else
                {
                    operationFlag = false;
                }
            }
            catch (System.Exception se)
            {
                int ret = Marshal.GetLastWin32Error();
            }
            finally
            {
                if (wic != null)
                {
                    wic.Undo();
                }
            }

            return operationFlag;
        }
    }
}
