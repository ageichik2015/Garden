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
    public partial class ChildEdirForm : Form
    {

        public ChildInfo _newChild = new ChildInfo();

        public ChildEdirForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_newChild.ChildID > 0)
            {
                _newChild.UpdateChild();
            }
            else
            {
                _newChild.InsertNewChild();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChildEdirForm_Load(object sender, EventArgs e)
        {
            GroupList _groupList = GroupList.GetDefaultGroupList();
            GrouplistbindingSource.DataSource = _groupList;

            childInfoBindingSource.DataSource = _newChild;
        }
    }
}
