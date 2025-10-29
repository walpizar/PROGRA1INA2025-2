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
    public partial class frmPacienteLista : Form
    {
        //defino la lista de pacientes
        List<clsPaciente> lista;

        //defino la instancia de pacientes para ir de la capa ui a service
        private readonly PacienteService _pacienteService;

        //variable para saber si estoy mostrando inactivos o activos
        private bool mostrarInactivos = false;

        public frmPacienteLista()
        {
            InitializeComponent();

            //centro el form en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            //aqui lo inicializo la instancia
            _pacienteService = new PacienteService();
        }

        //evento cargar form pacienteLista
        private void frmPacienteLista_Load(object sender, EventArgs e)
        {
            try
            {
                //llamo al metodo para saber que lista cargar si activos o inactivos
                cargarListaSegunCkeckBox();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de pacientes. Contacte con soporte o su administrador." +
                    "\n" + "Error: " + "\n" + ex.Message);
            }

        }

        //metodo para cargar la lista segun el radiobutton seleccionado
        private void cargarListaSegunCkeckBox()
        {
            //valido si el radiobutton activos esta seleccionado
            if (rdBtnActivos.Checked)
            {
                //llamo al metodo consultar todos del servicio para que me devuelva todos los pacientes activos
                var result = _pacienteService.consultarTodos();
               
                this.lista = result ?? new List<clsPaciente>();//si es null le asigno una lista vacia, el ?? lo que hace es validar si es null
                btnNuevo.Visible = true; //muestro el boton nuevo
                lblTitulo.Text = "Mantenimiento Pacientes";
                mostrarInactivos = false;
            }
            //valido si el radiobutton inactivos esta seleccionado
            else if (rdBtnInactivos.Checked)
            {
                //llamo al metodo consultar todos los inactivos para que me devuelva todos los pacientes inactivos
                var result = _pacienteService.consultarTodosInactivos();
                
                this.lista = result ?? new List<clsPaciente>();//si es null le asigno una lista vacia, el ?? lo que hace es validar si es null
                btnNuevo.Visible = false; //oculto el boton nuevo
                lblTitulo.Text = "Pacientes Inactivos";
                mostrarInactivos = true;
            }
            else
            {
                //si ningun radioBoton esta seleccionado, selecciono el de activos por defecto
                rdBtnActivos.Checked = true;

                var result = _pacienteService.consultarTodos();
                
                this.lista = result ?? new List<clsPaciente>();//si es null le asigno una lista vacia, el ?? lo que hace es validar si es null
                btnNuevo.Visible = true; //muestro el boton nuevo
                lblTitulo.Text = "Mantenimiento Pacientes";
                mostrarInactivos = false;
            }

            //y llamo al metodo cargar lista para que me cargue la lista de pacientes
            cargarLista(lista);
        }


        //evento click del boton nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                //instancio el formulario de paciente para poder mostrarlo
                frmPaciente frmPaciente = new frmPaciente();
                //Aqui lo muestro 
                frmPaciente.ShowDialog();

                //actualizo la lista de pacientes llamando al metodo consultar todos del servicio para que me devuelva todos los pacientes activos
                this.lista = _pacienteService.consultarTodos();
                //y llamo al metodo cargar lista para que me cargue la lista
                cargarLista(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de crear paciente. Contacte con soporte o su administrador." +
                    "\n" + "Error: " + "\n" + ex.Message);
            }

        }


        //metodo para cargar la lista de pacientes 
        private void cargarLista(List<clsPaciente> lista)
        {
            //limpio el listbox para evitar duplicados
            lstvListaPaciente.Items.Clear();

            //recorro la lista de pacientes 
            foreach (clsPaciente paciente in lista)
            {
                //creo un item para cada paciente
                ListViewItem item = new ListViewItem(paciente.id.ToString());

                //añado las subitems al item, el subItem es como una columna de una misma fila
                item.SubItems.Add(paciente.persona.nombre);
                item.SubItems.Add(paciente.persona.apellido1);
                item.SubItems.Add(paciente.persona.apellido2);
                item.SubItems.Add(paciente.persona.telefono);

                //añado el item al listbox
                lstvListaPaciente.Items.Add(item);
            }
        }

        //evento doble click en el listbox
        private void lstvListaPaciente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //validar si hay un elemento seleccionado
                if (lstvListaPaciente.SelectedItems.Count > 0)
                {
                    //extraigo el id del paciente seleccionado del listview los [0] son para que me coja la primera columna que es donde esta el id
                    string id = lstvListaPaciente.SelectedItems[0].SubItems[0].Text;

                    //aqui busco el paciente en la lista que tengo cargada en memoria
                    clsPaciente paciente = lista.Where(p => p.id.Equals(id)).SingleOrDefault();

                    //valido que el paciente no sea nulo
                    if (paciente != null)
                    {
                        //creo una instancia del formulario de paciente
                        frmPaciente frmPaciente = new frmPaciente();

                        //le paso el paciente seleccionado al formulario de crear paciente
                        frmPaciente.pacienteSelected = paciente;

                        //le paso a la variable mostrarBotonReactivar de frmPaciente el valor de mostrarInactivos para que sepa si esta mostrando inactivos o activos  
                        frmPaciente.mostrarBotonReactivar = mostrarInactivos;

                        //abro el formulario
                        frmPaciente.ShowDialog();

                        //actualizo la lista de pacientes llamando al metodo cargarListaSegunCkeckBox para que me cargue la lista segun el radiobutton seleccionado
                        cargarListaSegunCkeckBox();

                        //cierre del segundo if
                    }
                    //cierre del primer if
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario del paciente. Contacte con soporte o su administrador" +
                    "\n" + "Error: " + "\n" + ex.Message);
            }

        }


        //evento text changed del textbox de busqueda
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //filtro la lista de pacientes por nombre o id
                var listaFiltrada = this.lista.Where(p => p.persona.nombre.ToLower().Contains(txtBusqueda.Text.ToLower()) ||
                p.id.ToString().Contains(txtBusqueda.Text)).ToList();

                //llamo al metodo cargar lista y le paso por parametro la listaFiltrada para que me cargue la lista filtrada
                cargarLista(listaFiltrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar la lista de pacientes. Contacte con soporte o con su administrador." +
                    "\n" + "Error: " + "\n" + ex.Message);

            }
        }

        //evento check del radiobutton activos
        private void rdBtnActivos_CheckedChanged(object sender, EventArgs e)
        {
            //valido si el radiobutton activos esta seleccionado
            if (rdBtnActivos.Checked)
            {
                try
                {
                    //llamo al metodo consultar todos del servicio para que me devuelva todos los pacientes activos
                    this.lista = _pacienteService.consultarTodos();

                    txtBusqueda.Clear();//limpio el textbox de busqueda x si habia algo escrito

                    btnNuevo.Visible = true; //muestro el boton nuevo
                    lblTitulo.Text = "Mantenimiento Pacientes";
                    //cambio la variable mostrarInactivos a false
                    mostrarInactivos = false;
                    //y llamo al metodo cargar lista para que me cargue la lista
                    cargarLista(lista);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la lista de pacientes activos. Contacte con soporte o su administrador." +
                        "\n" + "Error: " + "\n" + ex.Message);
                }
            }

        }

        //evento check del radiobutton inactivos
        private void rdBtnInactivos_CheckedChanged(object sender, EventArgs e)
        {
            //valido si el radiobutton inactivos esta seleccionado
            if (rdBtnInactivos.Checked)
            {
                try
                {
                    //llamo al metodo consultar todos del servicio para que me devuelva todos los pacientes inactivos
                    this.lista = _pacienteService.consultarTodosInactivos();

                    txtBusqueda.Clear();//limpio el textbox de busqueda x si habia algo escrito

                    btnNuevo.Visible = false; //oculto el boton nuevo
                    lblTitulo.Text = "Pacientes Inactivos";
                    //cambio la variable mostrarInactivos a true
                    mostrarInactivos = true;
                    //y llamo al metodo cargar lista para que me cargue la lista
                    cargarLista(lista);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la lista de pacientes inactivos. Contacte con soporte o su administrador." +
                        "\n" + "Error: " + "\n" + ex.Message);
                }

            }
        }
    }
}
