using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using cwbx;

namespace PasswordReset
{
    public partial class Form1 : Form
    {
        [DllImport("wtsapi32.dll", SetLastError = true)]
        static extern bool WTSDisconnectSession(IntPtr hServer, int sessionId, bool bWait);
        const int WTS_CURRENT_SESSION = -1;
        static readonly IntPtr WTS_CURRENT_SERVER_HANDLE = IntPtr.Zero;

        private AS400System as400 = new AS400System();

        public Form1()
        {
            InitializeComponent();
        }

        private string getUser()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToUpper().Trim().Substring(
                System.Security.Principal.WindowsIdentity.GetCurrent().Name.Trim().LastIndexOf("\\") + 1);
        }

        private bool isUserAdmin(String user)
        {
            bool result = false;
            if (user == "ADMIN") //add other usernames here - must be admin on windows and as400
                result = true;
            return result;
        }

        public String VerifyUserPass(String username, String password)
        {
            String result = "";
            try
            {
                as400.VerifyUserIDPassword(username, password);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        public String ChangePassword(String username, String oldpass, String newpass)
        {
            String result = "";
            try
            {
                as400.ChangePassword(username, oldpass, newpass);
            }
            catch (Exception e)
            {
                result = e.Message;
            }
            return result;
        }

        private String ExecCommand(String cmdtxt)
        {
            String result = "";
            Command cmd = new Command { system = as400 };
            try
            {
                cmd.Run(cmdtxt);
            }
            catch (Exception e)
            {
                result = e.Message;
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = getUser();
            String oldpass = tbOldPass.Text.Trim();
            String newpass = tbNewPassword.Text.Trim();
            bool isAdmin = isUserAdmin(user);

            if (isAdmin) user = tbUser.Text.Trim();

            if (newpass != tbRepeat.Text.Trim())
            {
                MessageBox.Show("Passwords do not match.", "Error");
                return;
            }
            
            if (newpass == "")
            {
                MessageBox.Show("New password can't be blank.", "Error");
                return;
            }

            if (newpass.Length>10)
            {
                MessageBox.Show("New password can't be more than 10 characters.", "Error");
                return;
            }

            //need more password checks

            PrincipalContext pc = new PrincipalContext(ContextType.Domain, "DOMAIN1");

            if (!isAdmin)
            {
                if (!pc.ValidateCredentials(user, oldpass))
                {
                    MessageBox.Show("Old password is invalid on Windows domain.", "Error");
                    return;
                }

                if (VerifyUserPass(user, oldpass)!="")
                {
                    MessageBox.Show("Old password is invalid on AS400.", "Error");
                    return;
                }

            }

            UserPrincipal userAccount = UserPrincipal.FindByIdentity(pc, IdentityType.SamAccountName, user);
            if (userAccount == null)
            {
                MessageBox.Show("Windows account does not exist.", "Error");
                return;
            }

            if (isAdmin)
            {
                //change password
                if (userAccount != null)
                {
                    userAccount.SetPassword(newpass);
                    userAccount.Enabled = true;
                    userAccount.Save();
                }

                //change on as400 and enable if we are admin
                ExecCommand($"CHGUSRPRF USRPRF({user}) PASSWORD({newpass}) STATUS(*ENABLED)");

                MessageBox.Show("Password successfully changed and accounts enabled, user must log out and back in.", "Success!");
            }
            else
            {
                try
                {
                    userAccount.ChangePassword(oldpass, newpass);
                    userAccount.Save();

                    ChangePassword(user, oldpass, newpass);

                    MessageBox.Show("Password successfully changed. You must log out and back in.", "Success!");

                    //WTSDisconnectSession(WTS_CURRENT_SERVER_HANDLE, WTS_CURRENT_SESSION, false);
                    Process.Start("C:\\Windows\\system32\\shutdown.exe","/r /t:01");
                    Application.Exit();
                }
                catch (PasswordException exception)
                {
                    MessageBox.Show(exception.Message, "Invalid Password");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Determine if user is super-user
            tbUser.Text = getUser();
            if (isUserAdmin(getUser()))
            {
                //if yes, disable previous password box and set global var allowing reset for anybody
                tbUser.ReadOnly = false;
                lAdmin.Visible = true;
                tbOldPass.Visible = false;
                lPrevPW.Visible = false;
                lWarning.Visible = false;
            }
            as400.Define("MY400");
            as400.Connect(cwbcoServiceEnum.cwbcoServiceRemoteCmd);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
