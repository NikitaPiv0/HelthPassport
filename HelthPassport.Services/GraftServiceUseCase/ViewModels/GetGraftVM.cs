using HelthPassport.Entities;

namespace HelthPassport.Services.GraftServiceUseCase.ViewModels
{
    public class GetGraftVM
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }

        public GetGraftVM(
            Guid id = default,
            DateTime date = default,
            string name = null)
        {
            Id = id;
            Date = date;
            Name = name;
        }

        public GetGraftVM(Graft graft)
        {
            Id = graft.Id;
            Date = graft.Date;
            Name = graft.Name;
        }
    }
}