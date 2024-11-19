namespace WinFormsApp1
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Position { get; set; } = string.Empty; // Инициализация, чтобы избежать null
        public DateTime HireDate { get; set; }
        public string ContactInfo { get; set; } = string.Empty; // Инициализация, чтобы избежать null
        public int EnterpriseId { get; set; }
    }
}
