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
    public partial class FrmMantenimientoAdmin : Form
    {

        List<clsUsuario> listaAdmins;
        private readonly UsuarioService _UsuarioService;
        public FrmMantenimientoAdmin()
        {
            InitializeComponent();
            _UsuarioService = new UsuarioService();
        }


        private void CargarAdmins()
        {
            try
            {
                var admins = _UsuarioService.consultarTodos();
                cargarList(admins);
                MessageBox.Show("Lista de administradores cargada correctamente");


            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar la lista de administradores");
            }
       

        }

        private void cargarList(List<clsUsuario> admins)
        {
            listView1.Items.Clear(); // limpiamos el ListView del form

            foreach (clsUsuario admin in admins)
            {
                ListViewItem item = new ListViewItem(admin.personaId);
                //item.SubItems.Add(admin.personaTipoId.ToString());
                //item.SubItems.Add(admin.contrasena);
                item.SubItems.Add(
                        admin.persona != null
                            ? $"{admin.persona.nombre} {admin.persona.apellido1} {admin.persona.apellido2}"
                            : "Sin datos"
                    );
                item.SubItems.Add(admin.nombre_usuario);
                item.SubItems.Add(admin.email);

                listView1.Items.Add(item); // lo agregamos al ListView real
            }
        }


        private void FrmMantenimientoAdmin_Load(object sender, EventArgs e)
        {
            CargarAdmins();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnadirAdmin frmAnadirAdmin = new FrmAnadirAdmin();
            frmAnadirAdmin.ShowDialog();
        }
    }
}
