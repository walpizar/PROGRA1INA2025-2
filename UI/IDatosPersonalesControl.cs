
namespace UI
{
    public interface IDatosPersonalesControl
    {
        string Apellido1 { get; }
        string Apellido2 { get; }
        string Direccion { get; }
        string Email { get; }
        DateTime FechaNacimiento { get; }
        string Identificacion { get; }
        string Nombre { get; }
        string Telefono { get; }
        string TipoIdentificacion { get; }

        void Validar();
    }
}