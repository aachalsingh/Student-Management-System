using Student_Management_System_final.Screens.Branches;
using Student_Management_System_final.Screens.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System_final.Screens
{
    public partial class DashboardForm : TemplateForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void newSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
         //   Application.OpenForms(get);
        }

        private void ManageBrancesToolStripButton_Click(object sender, EventArgs e)
        {
            ManageBranchesForm mbf = new ManageBranchesForm();
            mbf.ShowDialog();
        }
    }
}
