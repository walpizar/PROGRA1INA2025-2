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


        public frmPacienteLista()
        {
            InitializeComponent();

            //aqui lo inicializo la instancia
            _pacienteService = new PacienteService();
        }

        //evento cargar form
        private void frmPacienteLista_Load(object sender, EventArgs e)
        {
            try
            {
                //llamo al metodo consultar todos para que me devuelva la lista de pacientes
                this.lista = _pacienteService.consultarTodos();
                //llamo al metodo cargar lista para que me cargue la lista
                cargarLista(lista);

            }

            catch (Exception)
            {
                MessageBox.Show("Error al cargar la lista de pacientes");
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
                item.SubItems.Add(paciente.Persona.nombre);
                item.SubItems.Add(paciente.Persona.apellido1);
                item.SubItems.Add(paciente.Persona.apellido2);
                item.SubItems.Add(paciente.Persona.telefono);

                //añado el item al listbox
                lstvListaPaciente.Items.Add(item);
            }
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

                //actualizo la lista de pacientes
                this.lista = _pacienteService.consultarTodos();
                //y llamo al metodo cargar lista para que me cargue la lista
                cargarLista(lista);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir el formulario de paciente");
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
                    int id = int.Parse(lstvListaPaciente.SelectedItems[0].SubItems[0].Text);

                    //aqui busco el paciente en la lista que tengo cargada en memoria
                    clsPaciente paciente = lista.Where(p => p.id.Equals(id)).SingleOrDefault();

                    //valido que el paciente no sea nulo
                    if (paciente != null)
                    {
                        //creo una instancia del formulario de paciente
                        frmPaciente frmPaciente = new frmPaciente();

                        //le paso el paciente seleccionado al formulario de crear paciente
                        frmPaciente.pacienteSelected = paciente;

                        //abro el formulario
                        frmPaciente.ShowDialog();

                        //actualiar la lista
                        this.lista = _pacienteService.consultarTodos();
                        //y llamo al metodo cargar lista para que me cargue la lista
                        cargarLista(lista);

                        //cierre del segundo if
                    }
                    //cierre del primer if
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir el formulario de paciente");
            }

        }


        //evento text changed del textbox de busqueda
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //filtro la lista de pacientes por nombre o id
            var listaFiltrada = this.lista.Where(p => p.Persona.nombre.ToLower().Contains(txtBusqueda.Text.ToLower()) ||
            p.id.ToString().Contains(txtBusqueda.Text)).ToList();

            //llamo al metodo cargar lista y le paso por parametro la listaFiltrada para que me cargue la lista filtrada
            cargarLista(listaFiltrada);

        }
    }
}
