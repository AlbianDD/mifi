using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zayvki
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            if(DataClass.Click_Type == "About")
            {
                AboutView();
            } else
            {
                HelpView();
            }
        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearLabel();
        }

        private void HelpView()
        {
            label1.Visible = true;
        }

        private void AboutView()
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void ClearLabel()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
    }
}

