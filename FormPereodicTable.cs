using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChemistryEducation
{
    public partial class FormPereodicTable : Form
    {
        ApplicationContext db;
        public FormPereodicTable()
        {
            InitializeComponent();
            db = new ApplicationContext();
            flowLayoutPanelResult.AutoScroll = true;
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanelResult.Controls.Clear();
            string searchQuerry = textBoxSearch.Text;
            if (searchQuerry != string.Empty)
            {
                List<ChemicalElement> elements = db.PeriodicTable
                .Where(el => el.ElementNumber.Contains(searchQuerry) || el.ElementName.Contains(searchQuerry) || el.ElementFullname.Contains(searchQuerry) || el.MetalStatus.Contains(searchQuerry))
                .ToList();
                foreach (ChemicalElement element in elements)
                {
                    Label label = new Label();
                    label.Text = $"{element.ElementNumber}/ {element.ElementFullname}/ {element.Description}";
                    label.AutoSize = true;
                    flowLayoutPanelResult.Controls.Add(label);
                }
                if(elements.Count == 0)
                {
                    Label label = new Label();
                    label.Text = "Element not found!";
                    label.AutoSize = true;
                    flowLayoutPanelResult.Controls.Add(label);
                }
            }
        }
    }
}
