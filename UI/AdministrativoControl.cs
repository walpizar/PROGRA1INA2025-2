using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class AdministrativoControl : UserControl
    {
        public AdministrativoControl()
        {
            InitializeComponent();
        }

        // Propiedad para obtener o asignar el puesto seleccionado
        public string Puesto
        {
            get { return comboPuesto.SelectedItem?.ToString(); }
            set { comboPuesto.SelectedItem = value; }
        }

        // Propiedad para obtener o asignar la descripción
        public string Descripcion
        {
            get { return txtDescripcion.Text; }
            set { txtDescripcion.Text = value; }
        }

        // Método para cargar una lista de puestos en el ComboBox
        public void CargarPuestos(List<string> puestos)
        {
            comboPuesto.Items.Clear();
            comboPuesto.Items.AddRange(puestos.ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento del label, lo puedes dejar vacío o eliminar si no lo usas
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Evento del GroupBox, lo puedes usar si necesitas lógica al entrar
        }
    }
}
