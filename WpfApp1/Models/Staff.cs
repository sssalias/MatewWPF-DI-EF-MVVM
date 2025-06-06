namespace WpfApp1.Models
{
    internal class Staff
    {
        public int StaffID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportDetails { get; set; }

        // Навигационная ссылка на должность
        public int PositionID { get; set; }
        public virtual Position Position { get; set; }
    }
}
