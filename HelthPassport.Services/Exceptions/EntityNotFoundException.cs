namespace HelthPassport.Services.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string message = "Запись не найдена")
            : base(message)
        {
        }
    }
}