using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Zayvki
{
    public partial class MainForm : Form
    {
        private SqlConnection SqlConnection;
        private string ID;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "electronics_repairDataSet.Malfunction". При необходимости она может быть перемещена или удалена.
            this.malfunctionTableAdapter.Fill(this.electronics_repairDataSet.Malfunction);
            TabControl1.SelectTab(DataClass.Choice);
            this.usersTableAdapter.Fill(this.electronics_repairDataSet.Users);
            this.clientsTableAdapter.Fill(this.electronics_repairDataSet.Clients);
            if (DataClass.User_Type.Contains("Admin"))
            {

                this.applicationsTableAdapter.Fill(this.electronics_repairDataSet.Applications);
            }
            else
            {
                TabControl1.TabPages.Remove(UsersTab);
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(@"Data Source=DESKTOP-99C7SVJ;Initial Catalog=electronics_repair;Integrated Security=True");
            SqlConnection.Open();
            if (ID != "")
            {
                DialogResult dialogResult = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    switch (TabControl1.SelectedIndex)
                    {
                        case (0):
                            { 
                            SqlCommand cmd = new SqlCommand("DELETE Applications WHERE ID_Application = '" + ID + "'", SqlConnection);
                            cmd.ExecuteNonQuery();
                            break;
                            }
                        case (1):
                            {
                            SqlCommand cmd = new SqlCommand("DELETE Clients WHERE ID_Client = '" + ID + "'", SqlConnection);
                            cmd.ExecuteNonQuery();
                            break;
                            }
                        case (2):
                            {
                            SqlCommand cmd = new SqlCommand("DELETE Users WHERE ID_User = '" + ID + "'", SqlConnection);
                            cmd.ExecuteNonQuery();
                            break;
                            }
                    }
                    this.usersTableAdapter.Fill(this.electronics_repairDataSet.Users);
                    this.clientsTableAdapter.Fill(this.electronics_repairDataSet.Clients);
                    if (DataClass.User_Type == "Admin")
                    {

                        this.applicationsTableAdapter.Fill(this.electronics_repairDataSet.Applications);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста выберите запись!!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlConnection.Close();
        }
        private void Change_Click(object sender, EventArgs e)
        {
            DataForm Df = new DataForm();
            DataClass.Click_Type = "Change";
            DataClass.ID = Convert.ToString(TabControl1.SelectedIndex);
            if (Df.ShowDialog() == DialogResult.Yes) 
            {
                this.usersTableAdapter.Fill(this.electronics_repairDataSet.Users);
                this.clientsTableAdapter.Fill(this.electronics_repairDataSet.Clients);
                if (DataClass.User_Type == "Admin")
                {
                    this.applicationsTableAdapter.Fill(this.electronics_repairDataSet.Applications);
                }
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            DataForm Df = new DataForm();
            DataClass.Click_Type = "Add";
            DataClass.ID = Convert.ToString(TabControl1.SelectedIndex);
            if (Df.ShowDialog() == DialogResult.Yes)
            {
                this.usersTableAdapter.Fill(this.electronics_repairDataSet.Users);
                this.clientsTableAdapter.Fill(this.electronics_repairDataSet.Clients);
                if (DataClass.User_Type == "Admin")
                {
                    this.applicationsTableAdapter.Fill(this.electronics_repairDataSet.Applications);
                }
            }
        }
        private void Help_Click(object sender, EventArgs e)
        {
            DataClass.Click_Type = "Help";
            HelpForm hf = new HelpForm();
            hf.Show();
        }
        private void About_Click(object sender, EventArgs e)
        {
            DataClass.Click_Type = "About";
            HelpForm hf = new HelpForm();
            hf.Show();
        }

        private void Applications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataClass.ID_cell = dataGridApplications.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataClass.ID_cell = dataGridClients.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataClass.ID_cell = dataGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
