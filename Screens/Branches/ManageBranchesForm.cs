using Student_Management_System_final.Screens.Templates;
using Student_Management_System_final.Utilities.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System_final.Screens.Branches
{
    public partial class ManageBranchesForm : TemplateForm
    {
        public ManageBranchesForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBranchInfoScreen(0, false);
        }

        private void ShowBranchInfoScreen(int branchId, bool isUpdate)
        {
            BranchInfoForm bif = new BranchInfoForm();
            bif.BranchId = branchId;
            bif.IsUpdate = isUpdate;
            bif.ShowDialog();
        }

        private void ManageBranchesForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            ListData.LoadDataIntoDataGridView(BranchesDataGridView, "usp_BranchesGetAllBranches");
        }
    }
}
