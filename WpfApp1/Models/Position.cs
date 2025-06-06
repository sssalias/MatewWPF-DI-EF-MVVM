namespace WpfApp1.Models
{
    internal class Position
    {
        public int PositionID { get; set; }
        public string Title { get; set; }
        public decimal Salary { get; set; }
        public string Responsibilities { get; set; }
        public string Requirements { get; set; }

        // Навигационный доступ к сотрудникам данной должности
        public virtual ICollection<Staff> Employees { get; set; }
    }
}
