using WpfApp1.Models;

namespace WpfApp1.Core
{
    class DataLoader
    {
        private readonly DBContext dbContext;
        public DataLoader(DBContext _dbContext) {
            this.dbContext = _dbContext;
        }
        public void UploadData()
        {
            this.UploadPositions();
        }

        private void UploadPositions()
        {
            //this.dbContext.AddRange(
            //     new List<ProductType>
            //     {
            //         new ProductType { Title = "Администратор", Salary = 55000, Responsibilities = "Контроль работы над складом", Requirements = "Опыт работы 5 лет" },
            //         new ProductType { Title = "Логистический координатор", Salary = 45000, Responsibilities = "Контроль доставок", Requirements = "Опыт работы 3 года" },
            //         new ProductType { Title = "Складской оператор-приемщик", Salary = 35000, Responsibilities = "Контроль приёмок и качества товаров", Requirements = "Опыт работы 3 года" },
            //         new ProductType { Title = "Кладовщик-экспедитор", Salary = 35000, Responsibilities = "Организация погрузочно-разгрузочных работ", Requirements = "Опыт работы 3 года" },
            //         new ProductType { Title = "Инженер-технолог по хранению", Salary = 25000, Responsibilities = "Контроль хранения", Requirements = "Опыт работы не требуется" }
            //     }
            //);
            //this.dbContext.SaveChanges();
        }
    }
}
