using Entities;
using Services;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmControlAfiliados : Form
    {
        private readonly AfiliadoDonanteService _service;

        public FrmControlAfiliados(AfiliadoDonanteService service)
        {
            InitializeComponent();
            _service = service;
            this.Load += FrmControlAfiliados_Load; // asegurar que el evento Load esté conectado
        }

        private void FrmControlAfiliados_Load(object sender, EventArgs e)
        {
            lvAfiliados.View = View.Details;
            lvAfiliados.FullRowSelect = true;
            lvAfiliados.GridLines = true;

            lvAfiliados.Columns.Clear();
            lvAfiliados.Columns.Add("ID", 100);
            lvAfiliados.Columns.Add("Nombre", 150);
            lvAfiliados.Columns.Add("Apellido 1", 150);
            lvAfiliados.Columns.Add("Apellido 2", 150);
            lvAfiliados.Columns.Add("Correo", 200);

            CargarAfiliados();
        }

        private void CargarAfiliados()
        {
            lvAfiliados.Items.Clear();
            var afiliados = _service.ConsultarTodos();

            foreach (var a in afiliados)
            {
                if (a.persona != null) // asegurarse de que la relación esté cargada
                {
                    var item = new ListViewItem(a.personaId);
                    item.SubItems.Add(a.persona.nombre);
                    item.SubItems.Add(a.persona.apellido1);
                    item.SubItems.Add(a.persona.apellido2 ?? "");
                    item.SubItems.Add(a.persona.email ?? "");
                    lvAfiliados.Items.Add(item);
                }
            }
        }
    }
}
