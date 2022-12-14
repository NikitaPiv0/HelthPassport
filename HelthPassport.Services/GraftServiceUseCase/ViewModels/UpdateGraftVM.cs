namespace HelthPassport.Services.GraftServiceUseCase.ViewModels
{
    public class UpdateGraftVM
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }

        public UpdateGraftVM(
            Guid id = default,
            DateTime date = default,
            string name = null)
        {
            Id = id;
            Date = date;
            Name = name;
        }
    }
}