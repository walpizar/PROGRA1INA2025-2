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
                ListViewItem item = new ListViewItem(usuario.personaId.ToString());
                item.SubItems.Add(usuario.nombre_usuario);
                item.SubItems.Add(usuario.contrasena);
                //item.SubItems.Add(usuario.idRol.ToString());
                lstvLista.Items.Add(item);

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();

            //actualizar la lista
            this.lista = _usuarioService.consultarTodos();
            cargarLista(lista);

        }

        private void lstvLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //validar si hay un elemento seleccionado
                if (lstvLista.SelectedItems.Count > 0)
                {
                    //extraigo el id del usuario seleccionado de la listview
                    int idRol = int.Parse(lstvLista.SelectedItems[0].SubItems[0].Text);

                    //consulto el cliente por idRol a la lista
                    //clsUsuario usuario; 
                    //= lista.Where(u => u.idRol == idRol).SingleOrDefault();
                    //if (usuario != null)
                    //{
                    //    //Creo una instancia del formulario de cliente
                    //    frmUsuario frmUsuario = new frmUsuario();
                    //    //Le asigno a la propiedad el usuario seleccionado
                    //    frmUsuario.usuarioSelected = usuario;
                    //    frmUsuario.ShowDialog();

                    //    //actualizar la lista
                    //    this.lista = _usuarioService.consultarTodos();
                    //    cargarLista(lista);
                    //}

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el usuario de la lista");
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
                    (!string.IsNullOrEmpty(u.nombre_usuario) && u.nombre_usuario.ToUpper().Contains(criterio)) ||
                    (!string.IsNullOrEmpty(u.contrasena) && u.contrasena.ToUpper().Contains(criterio))
                ).ToList();
            }

            cargarLista(listaFiltrada);

        }
    }
}
