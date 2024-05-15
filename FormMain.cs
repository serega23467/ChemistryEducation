using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemistryEducation
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pictureBoxTable_Click(object sender, EventArgs e)
        {
            FormPereodicTable formPereodicTable = new FormPereodicTable();
            formPereodicTable.Show();
        }

        private void listViewTopics_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(listViewTopics.SelectedItems.Count > 0) 
            {
                int index = listViewTopics.SelectedIndices[0];
                tabControl.SelectedIndex = index;
            }
        }
    }
}
