using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class frmDonanteLista : Form
    {
        //instancio la lista de donantes
        List<clsDonante> donanteLst;

        //llamo al service
        donanteService donanteService;

        //modo seleccion
        public bool esSeleccion { get; set; } = false;

        private clsDonante donanteSel; // Campo para almacenar el donante seleccionado
        
        public clsDonante donanteSelected { get; set; } // Propiedad pública para acceder al donante seleccionado




        public frmDonanteLista()
        {
            //instancio el service
            donanteService = new donanteService();

            InitializeComponent();
        }

        private void frmDonanteLista_Load(object sender, EventArgs e)
        {
            try
            {
                //modo seleccion
                if (esSeleccion)
                {
                    this.Text = "SELECCIONAR DONANTE";
                    this.lblMantDonante.Text = "SELECCIONAR DONANTE";
                    this.btnDonanteSelect.Visible = true; 
                }
                else
                {
                    btnDonanteSelect.Visible = false;
                }

                donanteLst = donanteService.consultarTodos();
                cargarLista(donanteLst.Where(d => d.estado == true).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de donantes: " + ex.Message);
            }
        }

        private void cargarLista(List<clsDonante> lista)
        {
            lstvwDonanteLista.Items.Clear();
            foreach (var donante in lista)
            {
                var item = new ListViewItem(donante.personaId.ToString());
                // item.SubItems.Add(donante.personaTipoId.ToString());
                item.SubItems.Add(donante.persona.nombre);
                item.SubItems.Add(donante.persona.apellido1);
                item.SubItems.Add(donante.persona.apellido2);
                item.SubItems.Add(donante.tipoDonante == 1 ? "Afiliado" : "Ocasional");
                item.SubItems.Add(donante.persona.email);
                item.SubItems.Add(donante.persona.telefono);

                lstvwDonanteLista.Items.Add(item);
            }
        }

        private void chkbxDonanteActivar_CheckedChanged(object sender, EventArgs e)
        {
            //muestro los donantes activos o inactivos segun el checkbox
            if (chkbxDonanteActivar.Checked)
            {
                //mostrar inactivos
                cargarLista(donanteLst.FindAll(d => d.estado == false));
            }
            else
            {
                //mostrar activos
                cargarLista(donanteLst.FindAll(d => d.estado == true));
            }
        }

        private void btnNuevoDonante_Click(object sender, EventArgs e)
        {
            //ABRO EL FORMULARIO DE DONANTE EN MODO CREACION
            frmDonante frm = new frmDonante();
            frm.ShowDialog();

            //AL CERRAR EL FORMULARIO, ACTUALIZO LA LISTA
            chkbxDonanteActivar.Checked = false; //vuelvo a mostrar los activos
            donanteLst = donanteService.consultarTodos();
            cargarLista(donanteLst.FindAll(d => d.estado == true));
        }

        private void lstvwDonanteLista_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (lstvwDonanteLista.SelectedItems.Count > 0)
            {
                //busco el id del donante seleccionado
                string id = (lstvwDonanteLista.SelectedItems[0].Text);

                //busco el donante en la lista
                var donanteSel = donanteLst.Find(d => d.personaId == id);

                //abro el formulario de donante en modo modificacion
                frmDonante frmDonant = new frmDonante();
                frmDonant.donanteSelected = donanteSel;
                frmDonant.ShowDialog();

                //al cerrar el formulario, actualizo la lista
                chkbxDonanteActivar.Checked = false; //vuelvo a mostrar los activos
                donanteLst = donanteService.consultarTodos();
                cargarLista(donanteLst.FindAll(d => d.estado == true));
            }
        }

        private void txtbxBuscarDonante_TextChanged(object sender, EventArgs e)
        {
            //filtro la lista de donantes por nombre, apellido o email
            var filtro = txtbxBuscarDonante.Text.ToLower();
            var listaFiltrada = donanteLst.Where(d => d.estado == true).ToList();

            var donanteFiltrado = listaFiltrada.Where(d => d.persona.nombre.ToLower().Contains(filtro) ||
                                                       d.persona.apellido1.ToLower().Contains(filtro) ||
                                                       d.persona.apellido2.ToLower().Contains(filtro) ||
                                                       d.persona.email.ToLower().Contains(filtro)).ToList();
            cargarLista(donanteFiltrado);
        }

        private void lstvwDonanteLista_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstvwDonanteLista.SelectedItems.Count > 0)
            {
                //busco el id del donante seleccionado
                string id = lstvwDonanteLista.SelectedItems[0].Text;

                //busco el donante en la lista y lo guardo en el campo de clase
                donanteSel = donanteLst.Find(d => d.personaId == id);
            }
        }

        private void btnDonanteSelect_Click(object sender, EventArgs e)
        {
            //guardo el donante seleccionado en la propiedad publica
            if (donanteSel == null)
            {
                MessageBox.Show("Debe seleccionar un donante de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.donanteSelected = donanteSel;
            esSeleccion = false; //desactivo el modo seleccion
            this.Close();
        }
    }
}
