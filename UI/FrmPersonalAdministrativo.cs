using Entities;
using Services; 
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    // Este form lo uso para ver la lista de todos los admins y poder abrir el form de añadir/modificar

    public partial class FrmPersonalAdministrativo : Form
    {
        // Este form lo uso para ver la lista de todos los admins y poder abrir el form de añadir/modificar
        List<clsPersonalAdministrativo> lista;
        private readonly PersonalAdministrativoService _personalAdministrativoService;
        public FrmPersonalAdministrativo()
        {
            InitializeComponent();
            _personalAdministrativoService = new PersonalAdministrativoService();

        }

        // Al cargar el form, traigo todos los admins y los muestro
        private void FrmMantenimientoAdmin_Load(object sender, EventArgs e)
        {
            this.lista = _personalAdministrativoService.consultarTodos();
            cargarLista(lista);
        }

        // Lleno el ListView con los admins que tengo en la lista
        public void cargarLista(List<clsPersonalAdministrativo> lista)
        {
            try
            {

                listAdministradores.Items.Clear();

                foreach (clsPersonalAdministrativo administrador in lista)
                {
                    ListViewItem item = new ListViewItem(administrador.persona.nombre);
                    item.SubItems.Add(administrador.persona.apellido1 + " " + administrador.persona.apellido2);
                    item.SubItems.Add(administrador.persona.email);
                    item.SubItems.Add(administrador.Puesto.Nombre);

                    item.Tag = administrador.personaId;
                    listAdministradores.Items.Add(item);
                    //MessageBox.Show("Personal administrativo cargado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("Error al cargar el personal administrativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para abrir el form de añadir admin
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnadirPersonalAdministrativo frmAnadirAdmin = new FrmAnadirPersonalAdministrativo();
            frmAnadirAdmin.ShowDialog();
            // Recargo la lista después de cerrar el form
            this.lista = _personalAdministrativoService.consultarTodos();
            cargarLista(lista);
        }


        // Doble click en un admin abre el form para editar
        private void listAdministradores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (listAdministradores.SelectedItems.Count > 0)
                {
                    string id = listAdministradores.SelectedItems[0].Tag.ToString();

                    clsPersonalAdministrativo Admin = lista.Where(a => a.persona.id == id).SingleOrDefault();

                    if (Admin != null)
                    {
                        FrmAnadirPersonalAdministrativo frmAnadirPersonalAdministrativo = new FrmAnadirPersonalAdministrativo();
                        frmAnadirPersonalAdministrativo.adminSeleccionado = Admin;
                        frmAnadirPersonalAdministrativo.ShowDialog();
                        // Recargo la lista después de modificar
                        this.lista = _personalAdministrativoService.consultarTodos();
                        cargarLista(lista);
                    }

                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el personal administrativo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
