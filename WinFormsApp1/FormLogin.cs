using System;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent(); // ОБЯЗАТЕЛЬНО оставь этот вызов
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Пожалуйста, заполните логин и пароль.");
                return;
            }

            using (var connection = new NpgsqlConnection("Host=194.164.33.111;Port=5432;Username=283;Password=rewq283;Database=283_Maksimov"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM account WHERE login = @login AND password = @password";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("login", txtUsername.Text);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                this.Hide();
                                FormWorkHoursTracker mainForm = new FormWorkHoursTracker();
                                mainForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Неверные учетные данные, попробуйте еще раз.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
