namespace HelthPassport.Services.EmployeePositionServiceCase.ViewModels
{
    public class CreateEmployeePositionVM
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }

        public CreateEmployeePositionVM(
            string name = null,
            Guid categoryId = default,
            string categoryName = null)
        {
            Name = name;
            CategoryId = categoryId;
            CategoryName = categoryName;
        }
    }
}