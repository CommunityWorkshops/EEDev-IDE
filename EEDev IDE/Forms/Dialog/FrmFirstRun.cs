using System;
using System.Windows.Forms;
using EEDev_IDE.Classes.IO;
using EEDev_IDE.Data.Models;


namespace EEDev_IDE.Forms.Dialog
{
    public partial class FrmFirstRun : Form
    {
        public FrmFirstRun()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Has the form been completed correctly?

            if (string.IsNullOrEmpty(tbName.Text))
            {
                //TODO: Requires Localization
                ErrorMessage("You must Include your Name");
                return;
            }

            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                //TODO: Requires Localization
                ErrorMessage("A Valid Email Address Is Required");
                return;
            }

            //TODO: Improve Password Security... No limit on length beyond the limit of a string length, and proper complexity.
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                //TODO: Requires Localization
                ErrorMessage("A Password is Required");
                return;
            }

            if (tbPassword.Text != tbPasswordConfirm.Text)
            {
                //TODO: Requires Localization
                ErrorMessage("Passwords do not Match");
                return;
            }


            // Ok everything is fine now.
            //TODO: Write Proper XMLSerialization / DeSerialization Class
            // Just save as a Text file for just now
            var um = new UserModel
            {
                Name = tbName.Text,
                Email = tbEmail.Text,
                Password = tbPassword.Text,
                Facebook = cbFacebookAccount.Checked,
                GitHub = cbGithubAccount.Checked,
                Twitter = cbTwitterAccount.Checked
            };

            var fi = new FileIo();
            fi.WriteUserTextFile();
            
            //TODO: Log into the Server so that the user's statistics are saved, answers to their questions are displayed, no information on their projects is shown, and so that they can download new or updated libraries that they are currently using. Enable Chat if they wish etc... 


            DialogResult = DialogResult.OK;
            Close();

        }

        private static void ErrorMessage(string message)
        {
            //TODO: Requires Localization
            MessageBox.Show(message, "Validation of the Form failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
