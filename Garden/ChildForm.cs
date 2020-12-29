using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenLibrary;

namespace Garden
{
    public partial class ChildForm : Form
    {

        ChildList _childList = new ChildList();

        public ChildForm()
        {
            InitializeComponent();
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshChildList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChildEdirForm newForm = new ChildEdirForm();

            newForm.ShowDialog();
            RefreshChildList();
        }

        void RefreshChildList()
        {
            _childList = ChildList.GetDefaultChildList();
            childListBindingSource.DataSource = null;
            childListBindingSource.DataSource = _childList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int chilID = (int)childListDataGridView.SelectedRows[0].Cells[0].Value;

            foreach (ChildInfo child in _childList)
            {
                if (child.ChildID == chilID)
                {
                    child.DeleteChild();
                }
            }
            RefreshChildList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int chilID = (int)childListDataGridView.SelectedRows[0].Cells[0].Value;

            ChildEdirForm newForm = new ChildEdirForm();

            foreach (ChildInfo child in _childList)
            {
                child.GetChild(chilID);
                newForm._newChild = child;
            }
            newForm.ShowDialog();
            RefreshChildList();
        }
    }
}
