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
    public partial class frmListaUsuarios : Form
    {
        List<clsUsuario> _listaUsuarios;
        private readonly UsuarioService _usuarioService;

        // Modifica el constructor para que reciba el servicio
        public frmListaUsuarios(UsuarioService usuarioService)
        {
            InitializeComponent();

            var context = new dbContextINA();
            var usuarioDAO = new UsuarioDAO(context);
            _usuarioService = new UsuarioService(usuarioDAO);
            _usuarioService = usuarioService;

          
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.ShowDialog();

            //actualizar la _listaUsuarios
            this._listaUsuarios = _usuarioService.consultarTodos();
            cargarLista(_listaUsuarios);
        }

        private void cargarLista(List<clsUsuario> lista)
        {
            lstvLista.Items.Clear();
            foreach (clsUsuario usuario in lista)
            {
                ListViewItem item = new ListViewItem(usuario.idRol.ToString());
                item.SubItems.Add(usuario.nombre_Usuario);
                item.SubItems.Add(usuario.contrasena);
                item.SubItems.Add(usuario.idRol.ToString());
                lstvLista.Items.Add(item);

            }
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

                    //consulto el cliente por idRol a la _listaUsuarios
                    clsUsuario usuario = _listaUsuarios.Where(u => u.idRol == idRol).SingleOrDefault();
                    if (usuario != null)
                    {
                        //Creo una instancia del formulario de cliente
                        frmUsuario frmUsuario = new frmUsuario();
                        //Le asigno a la propiedad el usuario seleccionado
                        frmUsuario.usuarioSelected = usuario;
                        frmUsuario.ShowDialog();

                        //actualizar la _listaUsuarios
                        this._listaUsuarios = _usuarioService.consultarTodos();
                        cargarLista(_listaUsuarios);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el usuario de la _listaUsuarios");
            }
        }

        private void textBusqueda_TextChanged(object sender, EventArgs e)
        {
            //Filtrar por nombre y por el idRol
            var listaFiltrada = this._listaUsuarios.Where(u=>u.nombre_Usuario.ToUpper()
            .Contains(txtBusqueda.Text.ToUpper())||u.contrasena.Contains(txtBusqueda.Text.ToUpper())||
            u.idRol.ToString().Contains(txtBusqueda.Text.ToUpper())).ToList();

            // Volver a cargar el ListView con la _listaUsuarios filtrada
            cargarLista(listaFiltrada);
        }
    }
}
