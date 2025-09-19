
namespace Common.Exceptions
{
    [Serializable]
    public class EntityNotFoundDBException : Exception
    {
        public EntityNotFoundDBException()
        {
        }

        public EntityNotFoundDBException(string? message) : base(message)
        {
        }

        public EntityNotFoundDBException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}