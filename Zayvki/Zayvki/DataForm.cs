using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zayvki
{
    public partial class DataForm : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-99C7SVJ;Initial Catalog=electronics_repair;Integrated Security=True");
        private SqlDataAdapter sda;
        private DataTable dt = new DataTable();
        public DataForm()
        {
            InitializeComponent();
        }

       

        private void DataForm_Load(object sender, EventArgs e)
        {
            if (DataClass.Click_Type == "Add")
            {
                button1.Text = "Добавить";
            }
            else if (DataClass.Click_Type == "Change")
            {
                button1.Text = "Изменить";
                switch (DataClass.ID)
                {
                    case ("0"):
                        sda = new SqlDataAdapter("SELECT * FROM Applications WHERE ID_application = '" + DataClass.ID_cell + "'", sqlConnection);
                        sda.Fill(dt);
                        textBox1.ReadOnly = true;
                        textBox1.Text = dt.Rows[0][0].ToString();
                        textBox2.Text = dt.Rows[0][1].ToString();
                        textBox3.Text = dt.Rows[0][2].ToString();
                        textBox4.Text = dt.Rows[0][3].ToString();
                        textBox5.Text = dt.Rows[0][4].ToString();
                        textBox6.Text = dt.Rows[0][5].ToString();
                        break;
                    case ("1"):
                        sda = new SqlDataAdapter("SELECT * FROM Сlients WHERE ID_client = '" + DataClass.ID_cell + "'", sqlConnection);
                        sda.Fill(dt);
                        textBox4.ReadOnly = true;
                        textBox4.Text = dt.Rows[0][0].ToString();
                        textBox5.Text = dt.Rows[0][1].ToString();
                        textBox6.Text = dt.Rows[0][2].ToString();
                        break;
                    case ("2"):
                        sda = new SqlDataAdapter("SELECT * FROM Malfunction WHERE ID_Malfunction = '" + DataClass.ID_cell + "'", sqlConnection);
                        sda.Fill(dt);
                        textBox4.ReadOnly = true;
                        textBox4.Text = dt.Rows[0][0].ToString();
                        textBox5.Text = dt.Rows[0][1].ToString();
                        textBox6.Text = dt.Rows[0][2].ToString();
                        break;
                    case ("3"):
                        sda = new SqlDataAdapter("SELECT * FROM Users WHERE ID_user = '" + DataClass.ID_cell + "'", sqlConnection);
                        sda.Fill(dt);
                        textBox3.ReadOnly = true;
                        textBox3.Text = dt.Rows[0][0].ToString();
                        textBox4.Text = dt.Rows[0][1].ToString();
                        textBox5.Text = dt.Rows[0][2].ToString();
                        textBox6.Text = dt.Rows[0][3].ToString();
                        break;
                }
            }
            string ID = DataClass.ID;
            switch (ID)
            {
                case "1":
                    {
                        ClientLabel();
                        break;
                    }
                case "2":
                    {
                        MalfunctionLabel();
                        break;
                    }
                case "3":
                    {
                        UserLabel();
                        break;
                    }
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (DataClass.Click_Type == "Change")
            {
                switch (DataClass.ID)
                {
                    case ("0"):
                        if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                        {
                            MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE [Applications] SET ID_client = '" + textBox2.Text + "', Date = '" + textBox3.Text + "', Status = '" + textBox4.Text + "', Device_Type = '" + textBox5.Text + "', ID_Malfunction = '" + textBox6.Text + "' WHERE ID_application = '" + textBox1.Text + "'", sqlConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Запись изменена");
                        }
                        break;
                    case ("1"):
                        if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                        {
                            MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE [Clients] SET full_name = '" + textBox5.Text + "', telephone_number = '" + textBox6.Text + "' WHERE ID_client = '" + textBox4.Text + "'", sqlConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Запись изменена");
                        }
                        break;
                    case ("2"):
                        if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                        {
                            MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE [Malfunction] SET Malfunction_Type = '" + textBox5.Text + "', Malfunction_description = '" + textBox6.Text + "' WHERE ID_Malfunction = '" + textBox4.Text + "'", sqlConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Запись изменена");
                        }
                        break;
                    case ("3"):
                        if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                        {
                            MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("UPDATE [Users] SET Login = '" + textBox4.Text + "', Password = '" + textBox5.Text + "', Type = '" + textBox6.Text + "' WHERE ID_user = '" + textBox3.Text + "'", sqlConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Запись изменена");
                        }
                        break;
                }
            }
            else
            {
                switch (DataClass.ID)
                {
                    case ("0"):
                        if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                        {
                            MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO [Applications] values (@ID_application, @ID_client, @Date, @Status, @Device_type, @ID_Malfunction)", sqlConnection);
                            cmd.Parameters.AddWithValue("ID_application", textBox1.Text);
                            cmd.Parameters.AddWithValue("ID_client", textBox2.Text);
                            cmd.Parameters.AddWithValue("Date", textBox3.Text);
                            cmd.Parameters.AddWithValue("Status", textBox4.Text);
                            cmd.Parameters.AddWithValue("Device_type", textBox5.Text);
                            cmd.Parameters.AddWithValue("ID_Malfunction", textBox6.Text);
                            cmd.ExecuteNonQuery();

                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            MessageBox.Show("Запись отправлена");
                        }
                        break;
                    case ("1"):
                        if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                        {
                            MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO [Clients] values (@ID_client, @full_name, @telephone_number)", sqlConnection);
                            cmd.Parameters.AddWithValue("ID_client", textBox4.Text);
                            cmd.Parameters.AddWithValue("full_name", textBox5.Text);
                            cmd.Parameters.AddWithValue("telephone_number", textBox6.Text);
                            cmd.ExecuteNonQuery();

                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            MessageBox.Show("Запись отправлена");
                        }
                        break;
                    case ("2"):
                        if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                        {
                            MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO [Malfunction] values (@ID_Malfunction, @Malfunction_Type, @Malfunction_description)", sqlConnection);
                            cmd.Parameters.AddWithValue("ID_Malfunction", textBox4.Text);
                            cmd.Parameters.AddWithValue("Malfunction_Type", textBox5.Text);
                            cmd.Parameters.AddWithValue("Malfunction_description", textBox6.Text);
                            cmd.ExecuteNonQuery();

                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            MessageBox.Show("Запись отправлена");
                        }
                        break;
                    case ("3"):
                        if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
                        {
                            MessageBox.Show("Пожалуйста заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO [Users] values (@ID_User, @Login, @Password, @Type)", sqlConnection);
                            cmd.Parameters.AddWithValue("ID_User", textBox3.Text);
                            cmd.Parameters.AddWithValue("Login", textBox4.Text);
                            cmd.Parameters.AddWithValue("Password", textBox5.Text);
                            cmd.Parameters.AddWithValue("Type", textBox6.Text);
                            cmd.ExecuteNonQuery();

                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            MessageBox.Show("Запись отправлена");
                        }
                        break;
                }
            }

        }

        private void ClientLabel()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label4.Text = "ID Клиента";
            label5.Text = "ФИО";
            label6.Text = "Номер телефона";
        }

        private void MalfunctionLabel()
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Text = "ID Неисправности";
            label5.Text = "Тип неисправности";
            label6.Text = "Описание неисправности";
        }

        private void UserLabel()
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Text = "ID Пользователя";
            label4.Text = "Логин";
            label5.Text = "Пароль";
            label6.Text = "Тип";
        }
    }
}

