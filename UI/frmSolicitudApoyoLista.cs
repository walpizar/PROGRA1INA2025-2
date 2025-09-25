using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Common.Enums.Enums;

namespace UI
{
    public partial class frmSolicitudApoyoLista : Form
    {
        private readonly SolicitudApoyoService _solicitudService;
        private readonly PacienteService _pacienteService;
        private List<clsSolicitudApoyo> listaSolicitudes;

        public frmSolicitudApoyoLista()
        {
            InitializeComponent();
            _solicitudService = new SolicitudApoyoService();
            _pacienteService = new PacienteService();
        }

        private void frmSolicitudApoyoLista_Load(object sender, EventArgs e)
        {
            cargarListaSolicitudes();
        }

        // Método que llena el ListView con solicitudes pendientes de aprobar
        public void cargarListaSolicitudes(string filtro = "")
        {
            // Obtener todas las solicitudes
            listaSolicitudes = _solicitudService.consultarTodos();

            // Filtrar solo las solicitudes pendientes (estado = 1)
            listaSolicitudes = listaSolicitudes
                .Where(s => s.estado == (int)EstadoAprobacionSolicitudApoyo.Pendiente)
                .ToList();

            // Aplicar filtro de búsqueda
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                filtro = filtro.Trim().ToLower();
                listaSolicitudes = listaSolicitudes.Where(s =>
                    s.idSolicitud.ToLower().Contains(filtro) ||
                    (s.idPaciente != null && s.idPaciente.ToLower().Contains(filtro))
                ).ToList();
            }

            // Limpiar el ListView
            lstvSolicitudes.Items.Clear();

            foreach (clsSolicitudApoyo solicitud in listaSolicitudes)
            {
                ListViewItem item = new ListViewItem(solicitud.idSolicitud);

                // Nombre completo del paciente
                string nombrePaciente = "";
                clsPaciente paciente = _pacienteService.consultarPorID(solicitud.idPaciente);
                if (paciente != null && paciente.persona != null)
                {
                    nombrePaciente = $"{paciente.persona.nombre} {paciente.persona.apellido1}";
                }
                item.SubItems.Add(nombrePaciente);

                // Justificación y equipos necesarios
                item.SubItems.Add(solicitud.justificacion ?? "");
                item.SubItems.Add(solicitud.equiposNecesarios ?? "");

                // Convertir estado int a nombre de Enum
                string nombreEstado = Enum.IsDefined(typeof(EstadoAprobacionSolicitudApoyo), solicitud.estado)
                    ? ((EstadoAprobacionSolicitudApoyo)solicitud.estado).ToString()
                    : "no se conoce";
                item.SubItems.Add(nombreEstado);

                // Fecha de la solicitud
                item.SubItems.Add(solicitud.fechaSolicitud.ToString("dd/MM/yyyy"));

                lstvSolicitudes.Items.Add(item);
            }
        }

        // Filtrado de búsqueda
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            cargarListaSolicitudes(txtBusqueda.Text);
        }

        // Nueva solicitud
        private void btnNuevaSolicitud_Click(object sender, EventArgs e)
        {
            frmSolicitudApoyo frm = new frmSolicitudApoyo();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                cargarListaSolicitudes();
            }
        }

        // Doble click para editar
        private void lstvSolicitudes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstvSolicitudes.SelectedItems.Count > 0)
            {
                string id = lstvSolicitudes.SelectedItems[0].SubItems[0].Text;
                clsSolicitudApoyo solicitud = listaSolicitudes
                    .Where(s => s.idSolicitud == id)
                    .SingleOrDefault();

                if (solicitud != null)
                {
                    frmSolicitudApoyo frm = new frmSolicitudApoyo
                    {
                        solicitudSelected = solicitud
                    };

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        cargarListaSolicitudes();
                    }
                }
            }
        }
    }
}
