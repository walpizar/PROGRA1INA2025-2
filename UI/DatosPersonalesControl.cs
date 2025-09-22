using System;
using System.Windows.Forms;
using static Common.Enums.Enums;

namespace UI
{
    public partial class DatosPersonalesControl : UserControl
    {
        public DatosPersonalesControl()
        {
            InitializeComponent();
            // No permitir fechas futuras
            dateFecha.MaxDate = DateTime.Today;
            combTipoId.DataSource = Enum.GetValues(typeof(TipoIdentificacion));
            combTipoId.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // 📌 Propiedades para exponer los valores ingresados
        public string Identificacion => txtIdentificacion.Text.Trim();
        public ComboBox ComboTipoId => combTipoId;

        // 📌 Propiedad para obtener directamente el valor seleccionado (enum)
        public TipoIdentificacion TipoSeleccionado
        {
            get
            {
                if (combTipoId.SelectedItem != null)
                    return (TipoIdentificacion)combTipoId.SelectedItem;
                throw new Exception("Debe seleccionar un tipo de identificación.");
            }
        }
        public string Nombre => txtNombre.Text.Trim();
        public string Apellido1 => txtApellido1.Text.Trim();
        public string Apellido2 => txtSegundoApellido.Text.Trim();
        public string Direccion => txtDireccion.Text.Trim();
        public string Telefono => txtTelefono.Text.Trim();
        public string Email => txtEmail.Text.Trim();
        //public string TipoIdentificacion => combTipoId.SelectedItem?.ToString() ?? string.Empty;
        public DateTime FechaNacimiento => dateFecha.Value;

        // 📌 Método opcional para validar aquí mismo
        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
                throw new Exception("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(Apellido1))
                throw new Exception("El primer apellido es obligatorio.");
            if (string.IsNullOrWhiteSpace(Email))
                throw new Exception("El email es obligatorio.");
        }
    }
}
