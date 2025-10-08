using DAO;
using Entities;
using Services;
using System;
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
    public partial class frmUsuarioLista : Form
    {
        List<clsUsuario> lista;
        private readonly UsuarioService _usuarioService;

        // Modifica el constructor para que reciba el servicio
        public frmUsuarioLista()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }


        private void frmUsuarioLista_Load(object sender, EventArgs e)
        {
            this.lista = _usuarioService.consultarTodos();
            cargarLista(lista);

        }

        private void cargarLista(List<clsUsuario> lista)
        {
            lstvLista.Items.Clear();
            foreach (clsUsuario usuario in lista)
            {
                ListViewItem item = new ListViewItem(usuario.nombre_Usuario);
                item.SubItems.Add(usuario.contrasena);
                item.SubItems.Add(usuario.idRol.ToString());
                lstvLista.Items.Add(item);

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();

            if (frmUsuario.ShowDialog() == DialogResult.OK)
            {
                this.lista = _usuarioService.consultarTodos();
                cargarLista(lista);
            }

        }

        private void lstvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstvLista.SelectedItems.Count > 0)
                {
                    // Obtener el nombre de usuario de la primera columna
                    string nombreUsuario = lstvLista.SelectedItems[0].SubItems[0].Text;

                    // Buscar el usuario en la lista
                    clsUsuario usuario = lista.FirstOrDefault(u => u.nombre_Usuario == nombreUsuario);

                    if (usuario != null)
                    {
                        frmUsuario frmUsuario = new frmUsuario();
                        frmUsuario.usuarioSelected = usuario;
                        frmUsuario.ShowDialog();

                        // Actualizar la lista después de cerrar
                        this.lista = _usuarioService.consultarTodos();
                        cargarLista(lista);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar el usuario de la lista: " + ex.Message);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string criterio = txtBusqueda.Text.Trim().ToUpper();

            List<clsUsuario> listaFiltrada;

            if (string.IsNullOrEmpty(criterio))
            {
                listaFiltrada = this.lista;
            }
            else
            {
                listaFiltrada = this.lista.Where(u =>
                    (!string.IsNullOrEmpty(u.nombre_Usuario) && u.nombre_Usuario.ToUpper().Contains(criterio)) ||
                    (!string.IsNullOrEmpty(u.contrasena) && u.contrasena.ToUpper().Contains(criterio)) ||
                    u.idRol.ToString().Contains(criterio)
                ).ToList();
            }

            cargarLista(listaFiltrada);

        }

        private void lstv_DoubleClick(object sender, MouseEventArgs e)
        {
            if (lstvLista.SelectedItems.Count > 0)
            {
                string nombreUsuario = lstvLista.SelectedItems[0].SubItems[0].Text;
                clsUsuario usuario = lista.FirstOrDefault(u => u.nombre_Usuario == nombreUsuario);

                if (usuario != null)
                {
                    frmUsuario frm = new frmUsuario();
                    frm.usuarioSelected = usuario;

                    // Abrir y esperar resultado
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        //Refrescar lista después de eliminar o modificar
                        this.lista = _usuarioService.consultarTodos();
                        cargarLista(lista);
                    }
                }
            }
        }
    }
}

