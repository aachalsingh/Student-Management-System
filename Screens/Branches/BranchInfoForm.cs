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

namespace Student_Management_System_final.Screens.Branches
{
    public partial class BranchInfoForm : TemplateForm
    {
        public BranchInfoForm()
        {
            InitializeComponent();
        }
        
        public int BranchId { get; set; }

        private void BranchNameTextBox_TextChanged(object sender, EventArgs e)
        {
            TopPanelLabel.Text = BranchNameTextBox.Text;
        }
    }
}
