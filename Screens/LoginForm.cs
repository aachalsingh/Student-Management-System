using JIDBFramework;
using Student_Management_System_final.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbParameter = JIDBFramework.DbParameter;

namespace Student_Management_System_final.Screens
{
    public partial class LoginForm : TemplateForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DbSQLServer db = new DbSQLServer(Utilities.AppSetting.ConnectionString()); 

                bool isLoginDetailsCorrect = Convert.ToBoolean(db.GetScalerValue("usp_UsersCheckLoginDetails",
                    GetParameters()));

                if (isLoginDetailsCorrect)
                {
                    this.Hide();

                    DashboardForm df = new DashboardForm();
                    df.Show();
                }
                else
                {
                    MessageBox.Show("Username/Password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DbParameter[] GetParameters()
        {
            List<DbParameter> parameters = new List<DbParameter>();
            DbParameter dbparam1 = new DbParameter();
            dbparam1.Parameter = "@UserName";
            dbparam1.Value = UserNameTextBox.Text;
            parameters.Add(dbparam1);

            DbParameter dbparam2 = new DbParameter();
            dbparam2.Parameter = "@Password";
            dbparam2.Value = PasswordTextBox.Text;
            parameters.Add(dbparam2);

            return parameters.ToArray();
        }

        private bool IsFormValid()
        {
            if (UserNameTextBox.Text.Trim() == String.Empty )
            {
                MessageBox.Show("Username is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTextBox.Clear();
                UserNameTextBox.Focus();
                return false;
            }

            if (PasswordTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Clear();
                PasswordTextBox.Focus();
                return false;
            }
            return true;
        }
    }
}
