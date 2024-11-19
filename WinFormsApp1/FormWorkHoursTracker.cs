using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    public partial class FormWorkHoursTracker : Form
    {
        private string connectionString = "Host=194.164.33.111;Port=5432;Username=283;Password=rewq283;Database=283_Maksimov";

        public FormWorkHoursTracker()
        {
            InitializeComponent();
            dataGridViewEmployee.AutoGenerateColumns = true;
            LoadEmployeeData();
            AddEditAndDeleteButtons();

            // Добавление привязки события к dataGridViewEmployee
            dataGridViewEmployee.CellContentClick += dataGridViewEmployee_CellContentClick;
        }

        private void AddEditAndDeleteButtons()
        {
            if (dataGridViewEmployee.Columns["btnEdit"] == null)
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
                {
                    Name = "btnEdit",
                    HeaderText = "Actions",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewEmployee.Columns.Add(btnEdit);
            }

            if (dataGridViewEmployee.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
                {
                    Name = "btnDelete",
                    HeaderText = "Actions",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewEmployee.Columns.Add(btnDelete);
            }
        }

        private void LoadEmployeeData()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT employee_id, position, hours, contact_info, enterprise_id FROM employee";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        DataTable dt = new DataTable();
                        using (var reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                            dataGridViewEmployee.DataSource = dt;
                        }

                        // Изменение заголовка столбца после загрузки данных
                        if (dataGridViewEmployee.Columns["hours"] != null)
                        {
                            dataGridViewEmployee.Columns["hours"].HeaderText = "Hours Worked";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading employee data: {ex.Message}");
                }
            }
        }


        private void dataGridViewEmployee_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == dataGridViewEmployee.Columns["btnEdit"].Index)
                {
                    // Реализация функции редактирования
                    EditEmployee(e.RowIndex);
                }
                else if (e.ColumnIndex == dataGridViewEmployee.Columns["btnDelete"].Index)
                {
                    DeleteEmployee(e.RowIndex);
                }
            }
        }

        private void EditEmployee(int rowIndex)
        {
            // Получение данных о сотруднике из строки
            int employeeId = Convert.ToInt32(dataGridViewEmployee.Rows[rowIndex].Cells["employee_id"].Value ?? 0);
            string position = dataGridViewEmployee.Rows[rowIndex].Cells["position"].Value?.ToString() ?? string.Empty;
            int hours = Convert.ToInt32(dataGridViewEmployee.Rows[rowIndex].Cells["hours"].Value ?? 0);
            string contactInfo = dataGridViewEmployee.Rows[rowIndex].Cells["contact_info"].Value?.ToString() ?? string.Empty;
            int enterpriseId = Convert.ToInt32(dataGridViewEmployee.Rows[rowIndex].Cells["enterprise_id"].Value ?? 0);

            // Отображение данных в текстовых полях для редактирования
            txtEmployeeID.Text = employeeId.ToString();
            txtPosition.Text = position;
            txtHoursWorked.Text = hours.ToString();
            txtContactInfo.Text = contactInfo;
            txtEnterpriseID.Text = enterpriseId.ToString();
        }

        private void DeleteEmployee(int rowIndex)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int employeeId = Convert.ToInt32(dataGridViewEmployee.Rows[rowIndex].Cells["employee_id"].Value ?? 0);
                    string query = "DELETE FROM employee WHERE employee_id = @employee_id";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("employee_id", employeeId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Record successfully deleted!");
                        LoadEmployeeData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting record: {ex.Message}");
                }
            }
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Проверка на существование employee_id
                    string checkQuery = "SELECT COUNT(*) FROM employee WHERE employee_id = @employee_id";
                    using (var checkCmd = new NpgsqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("employee_id", Convert.ToInt32(txtEmployeeID.Text));
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            // Если сотрудник уже существует, выполняем обновление
                            string updateQuery = "UPDATE employee SET position = @position, hours = @hours, contact_info = @contact_info, enterprise_id = @enterprise_id WHERE employee_id = @employee_id";
                            using (var updateCmd = new NpgsqlCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("employee_id", Convert.ToInt32(txtEmployeeID.Text));
                                updateCmd.Parameters.AddWithValue("position", txtPosition.Text);
                                updateCmd.Parameters.AddWithValue("hours", Convert.ToInt32(txtHoursWorked.Text));
                                updateCmd.Parameters.AddWithValue("contact_info", txtContactInfo.Text);
                                updateCmd.Parameters.AddWithValue("enterprise_id", Convert.ToInt32(txtEnterpriseID.Text));
                                updateCmd.ExecuteNonQuery();

                                MessageBox.Show("Employee details successfully updated!");
                            }
                        }
                        else
                        {
                            // Если сотрудник не существует, выполняем вставку новой записи
                            string insertQuery = "INSERT INTO employee (employee_id, position, hours, contact_info, enterprise_id) VALUES (@employee_id, @position, @hours, @contact_info, @enterprise_id)";
                            using (var insertCmd = new NpgsqlCommand(insertQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("employee_id", Convert.ToInt32(txtEmployeeID.Text));
                                insertCmd.Parameters.AddWithValue("position", txtPosition.Text);
                                insertCmd.Parameters.AddWithValue("hours", Convert.ToInt32(txtHoursWorked.Text));
                                insertCmd.Parameters.AddWithValue("contact_info", txtContactInfo.Text);
                                insertCmd.Parameters.AddWithValue("enterprise_id", Convert.ToInt32(txtEnterpriseID.Text));
                                insertCmd.ExecuteNonQuery();

                                MessageBox.Show("Data successfully saved!");
                            }
                        }
                    }

                    LoadEmployeeData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving data: {ex.Message}");
                }
            }
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtEmployeeID.Clear();
            txtPosition.Clear();
            txtHoursWorked.Clear();
            txtContactInfo.Clear();
            txtEnterpriseID.Clear();
        }
    }
}
