namespace Common.Exceptions
{
    public class EntityNotFoundDBException : Exception
    {
        public EntityNotFoundDBException() : base("La entidad no existe en la base de datos.") { }
        public EntityNotFoundDBException(string mensaje) : base(mensaje) { }
    }
}
