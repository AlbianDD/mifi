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
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
        }

        private void ChoiceForm_Load(object sender, EventArgs e)
        {
            if(DataClass.User_Type.Contains("Admin"))
            {
                button5.Visible = true;
            }
        }

        private void Applications_Click(object sender, EventArgs e)
        {
            MainForm Mf = new MainForm();
            DataClass.Choice = 0;
            Mf.Show();
            Hide();
        }
        
        private void Clients_Click(object sender, EventArgs e)
        {
            MainForm Mf = new MainForm();
            DataClass.Choice = 1;
            Mf.Show();
            Hide();
        }
        
        private void Malfunctions_Click(object sender, EventArgs e)
        {
            MainForm Mf = new MainForm();
            DataClass.Choice = 2;
            Mf.Show();
            Hide();
        }
        private void Users_Click(object sender, EventArgs e)
        {
            MainForm Mf = new MainForm();
            DataClass.Choice = 3;
            Mf.Show();
            Hide();
        }
    }
}
