using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zayvki
{
    public partial class Authorization : Form
    {
        private SqlConnection Conn;
        public Authorization()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string Login = LoginBox.Text;
            string Password = PassBox.Text;
            using (Conn = new SqlConnection(@"Data Source=DESKTOP-99C7SVJ;Initial Catalog=electronics_repair;Integrated Security=True"))
            {
                try
                {
                    Conn.Open();
                    string Query = "SELECT ID_User, [Type] FROM Users WHERE [Login] = @Login AND [Password] = @Password";
                    using (SqlCommand Cmd = new SqlCommand(Query, Conn))
                    {
                        Cmd.Parameters.AddWithValue("@Login", Login);
                        Cmd.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader Reader = Cmd.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                string UserId = Reader.GetString(0);
                                string User_Type = Reader.GetString(1);
                                ChoiceForm Cf = new ChoiceForm();
                                DataClass.User_Type = User_Type;
                                Cf.Show();
                                Conn.Close();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Ошибка: Неверный логин или пароль");
                            }
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"Ошибка: {Ex.Message}");
                }
                Conn.Close();
            }
        }
    }
}
