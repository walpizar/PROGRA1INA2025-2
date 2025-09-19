
namespace Services
{
    [Serializable]
    internal class EntityNotFoundDBException : Exception
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