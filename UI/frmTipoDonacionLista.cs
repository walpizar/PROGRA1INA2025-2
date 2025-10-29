using Common.Exceptions;
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
    public partial class frmTipoDonacionLista : Form
    {
        //instancio la lista de tipoDonacion
        List<clsTipoDonacion> tipoDonacionList;
        //llamo a service
        tipoDonacionService tipoDonacionService;

        //modo seleccion
        public bool esSeleccion { get; set; } = false;

        // Campo para almacenar el tipoDonacion seleccionado
        private clsTipoDonacion tipoDonacionSel;

        // Propiedad pública para acceder al tipoDonacion seleccionado
        public clsTipoDonacion tipoDonacionSelected { get; set; }

        public frmTipoDonacionLista()
        {
            //instancio el service
            tipoDonacionService = new tipoDonacionService();

            InitializeComponent();
        }



        private void frmTipoDonacionLista_Load(object sender, EventArgs e)
        {
            //inicio un try catch para cargar lista
            try
            {
                //MODO SELECCION
                if (esSeleccion)
                {
                    this.Text = "SELECCIONAR TIPO DE DONACIÓN";
                    this.lblManttipoDonacion.Text = "SELECCIONAR TIPO DE DONACIÓN";
                    this.btnSelecTipoDonacion.Visible = true;
                }
                else
                {
                    btnSelecTipoDonacion.Visible = false;
                }

                //cargo la lista de tipoDonacion
                this.tipoDonacionList = tipoDonacionService.consultarTodos();
                cargarlista(tipoDonacionList.Where(t => t.estado == true).ToList());
            }
            //catch personalizados en common.exceptions
            catch (EntityExistDBException ex) { MessageBox.Show(ex.Message); }
            catch (EntityNotFoundDBException ex) { MessageBox.Show(ex.Message); }
            catch (EntityNotExistDBException ex) { MessageBox.Show(ex.Message); }
            catch (EmailExistDBExeption ex) { MessageBox.Show(ex.Message); }
            catch (EntityActiveDBExeption ex) { MessageBox.Show(ex.Message); }
            catch (PhoneExistDBExeption ex) { MessageBox.Show(ex.Message); }
            catch (PriceNegativeException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de tipos de donación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cargarlista(List<clsTipoDonacion> tipoDonacionList)
        {
            try
            {

                //LIMPIO LA LIST VIEW
                lstvwTipoDonacionLista.Items.Clear();

                //RECORRO LA LISTA DE TIPO DONACION
                foreach (var tipoDonacion in tipoDonacionList)
                {
                    //CREO UN ITEM PARA LA LIST VIEW
                    ListViewItem item = new ListViewItem(tipoDonacion.idTipoDonacion.ToString());
                    item.SubItems.Add(tipoDonacion.nombreTipoDonacion);
                    item.SubItems.Add(tipoDonacion.descripcion);

                    //AGREGO EL ITEM A LA LIST VIEW
                    lstvwTipoDonacionLista.Items.Add(item);
                }



            }
            catch (EntityExistDBException ex) { MessageBox.Show(ex.Message); }
            catch (EntityNotFoundDBException ex) { MessageBox.Show(ex.Message); }
            catch (EntityNotExistDBException ex) { MessageBox.Show(ex.Message); }
            catch (EmailExistDBExeption ex) { MessageBox.Show(ex.Message); }
            catch (EntityActiveDBExeption ex) { MessageBox.Show(ex.Message); }
            catch (PhoneExistDBExeption ex) { MessageBox.Show(ex.Message); }
            catch (PriceNegativeException ex) { MessageBox.Show(ex.Message); }

            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de tipos de donación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstvwTipoDonacionLista_MouseClick(object sender, MouseEventArgs e)
        {
            //validar que se haya seleccionado un item
            if (lstvwTipoDonacionLista.SelectedItems.Count > 0)
            {
                //seleccionar el item
                int idTipoDonacion = int.Parse(lstvwTipoDonacionLista.SelectedItems[0].SubItems[0].Text);
                tipoDonacionSel = tipoDonacionList.Find(t => t.idTipoDonacion == idTipoDonacion);

                cargarRequerimientos(tipoDonacionSel);
            }

        }

        private void cargarRequerimientos(clsTipoDonacion tipoDonSelReq)
        {

            dgrdvwDonacionReq.Rows.Clear();

            dgrdvwDonacionReq.Rows.Add(
                tipoDonSelReq.requiereFrecuencia,
                tipoDonSelReq.requiereMonto,
                tipoDonSelReq.requiereTipoMoneda,
                tipoDonSelReq.requiereTipoTransaccion
            );
        }

        private void btnNuevotipoDonacion_Click(object sender, EventArgs e)
        {
            //abro el formulario de tipoDonacion en modo de creacion
            frmTipoDonacion formularioTipoDonacion = new frmTipoDonacion();
            formularioTipoDonacion.ShowDialog();

            //cuando se cierre el formulario de tipoDonacion, actualizo la lista de tipoDonacion
            chkbxTipoDonacAct.Checked = false; //vuelvo a mostrar los activos
            this.tipoDonacionList = tipoDonacionService.consultarTodos();
            cargarlista(tipoDonacionList.Where(t => t.estado == true).ToList());
        }

        private void lstvwTipoDonacionLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //proceder a seleccionar el item para modificarlo en el formulario de tipoDonacion en modo de modificacion
            try
            {
                //valido que se haya seleccionado un item
                if (lstvwTipoDonacionLista.SelectedItems.Count > 0)
                {
                    //obtengo el id del tipoDonacion seleccionado
                    int idTipoDonacion = int.Parse(lstvwTipoDonacionLista.SelectedItems[0].SubItems[0].Text);

                    //busco el tipoDonacion en la lista
                    clsTipoDonacion tipoDonacionSelect = tipoDonacionList.Find(t => t.idTipoDonacion == idTipoDonacion);

                    //abro el formulario de tipoDonacion en modo de modificacion
                    frmTipoDonacion formularioTipoDonacion = new frmTipoDonacion();
                    formularioTipoDonacion.tipoDonacionSelected = tipoDonacionSelect;
                    formularioTipoDonacion.ShowDialog();

                    //cuando se cierre el formulario de tipoDonacion, actualizo la lista de tipoDonacion
                    chkbxTipoDonacAct.Checked = false; //vuelvo a mostrar los activos
                    this.tipoDonacionList = tipoDonacionService.consultarTodos();
                    cargarlista(tipoDonacionList.Where(t => t.estado == true).ToList());
                }
                else
                {
                    MessageBox.Show("No hay tipos de donación para seleccionar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de tipos de donación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtbxBuscarTipoDonacion_TextChanged(object sender, EventArgs e)
        {
            //filtrar por nombre o id
            var tipoDonacionFiltrado = tipoDonacionList.Where(t => t.nombreTipoDonacion.ToLower().Contains(txtbxBuscarTipoDonacion.Text.ToLower()) ||
                    t.idTipoDonacion.ToString().Contains(txtbxBuscarTipoDonacion.Text)).ToList();

            cargarlista(tipoDonacionFiltrado);
        }

        private void chkbxTipoDonacAct_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxTipoDonacAct.Checked)
            {
                // Mostrar solo inactivos
                var listaInac = tipoDonacionList.Where(t => t.estado == false).ToList();
                cargarlista(listaInac);
            }
            else
            {
                // Mostrar solo activos
                var listaAct = tipoDonacionList.Where(t => t.estado == true).ToList();
                cargarlista(listaAct);
            }

        }

        private void btnSelecTipoDonacion_Click(object sender, EventArgs e)
        {
            //GUARDO EL TIPO DE DOANCION EN LA PROPIEDAD TIPO DONACION SELECTED Y CIERRO EL FORMULARIO
            if (tipoDonacionSel != null)
            {
                this.tipoDonacionSelected = tipoDonacionSel;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún tipo de donación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }

}
