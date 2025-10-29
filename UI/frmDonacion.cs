using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Services;
using static Common.Enums.Enums;

namespace UI
{
    public partial class frmDonacion : Form
    {
        //parametro para saber si estoy en modo creacion o edicion
        public clsDonacion donacionSelected { get; set; }

        //instancio el servicio de donacion
        public DonacionService donacionService;


        //donante tipoId seleccionado       
        private int tipoIdSeleccionado; // Campo privado en el formulario

        // campo privado para almacenar el tipo de donación seleccionado
        private clsTipoDonacion tipoDonacionSelected;

        //campo privado para donante seleccionado
        private clsDonante donanteSeleccionado;

        public frmDonacion()
        {
            donacionService = new DonacionService();

            InitializeComponent();
        }

        private void frmDonacion_Load(object sender, EventArgs e)
        {
            cargarCombo();

            //CAMPOS DE SOLO LECTURA
            txtbxDonacionID.ReadOnly = true;
            txtbxDonacionDonanteID.ReadOnly = true;
            txtbxDonacionTipoIdDonante.ReadOnly = true;
            txtbxDonacionIdTipoDonacion.ReadOnly = true;
            txtbxDonacionNombTipoDonacion.ReadOnly = true;

            if (donacionSelected != null)
            {
                //estoy en modo edicion

                this.Text = "MODIFICAR DONACION";
                btnGuardarDonacion.Text = "MODIFICAR";
                lblCrearDonacion.Text = "MODIFICAR DONACION";
                btnEliminarDonacion.Visible = true;



                //METODO CARGAR FORMULARIO MODIFICAR DONACION
                cargarFormModificarDonacion();
            }
            else
            {
                //estoy en modo creacion
                //oculto el boton eliminar
                btnEliminarDonacion.Visible = false;

                //limpio el formulario
                limpiarFrom();

                //obtengo el siguiente id
                int siguienteID = ObtenerSiguienteID();
                txtbxDonacionID.Text = siguienteID.ToString();
            }
        }

        private int ObtenerSiguienteID()
        {
            //consulto todos las donaciones y obtengo el maximo id + 1
            try
            {
                List<clsDonacion> donacionList = donacionService.consultarTodos();
                if (donacionList.Count == 0)
                {
                    return 1; //si no hay donaciones, el siguiente id es 1
                }
                else
                {
                    return donacionList.Max(d => d.idDonacion) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente ID: " + ex.Message);
                return -1;
            }

        }

        private void cargarFormModificarDonacion()
        {
            // cargo los datos del donacionSelected en el formulario
            txtbxDonacionID.Text = donacionSelected.idDonacion.ToString();
            txtbxDonacionDonanteID.Text = donacionSelected.donanteId.ToString();
            txtbxDonacionObservaciones.Text = donacionSelected.observaciones;

            // si la entidad donacion trae el tipo de donacion cargado, lo uso
            if (donacionSelected.tipoDonacion != null)
            {
                tipoDonacionSelected = donacionSelected.tipoDonacion;
                txtbxDonacionIdTipoDonacion.Text = tipoDonacionSelected.idTipoDonacion.ToString();
                txtbxDonacionNombTipoDonacion.Text = tipoDonacionSelected.nombreTipoDonacion;

                ActualizarDatosTipoDonacion();
            }
            else
            {
                // opcional: cargar desde servicio por id si hace falta
                // tipoDonacionSelected = tipoDonacionService.consultarPorID(donacionSelected.idTipoDonacion);
                // if (tipoDonacionSelected != null) ActualizarDatosTipoDonacion();
            }
        }

        private void txtbxDonacionIdTipoDonacion_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatosTipoDonacion();
        }
        private void ActualizarDatosTipoDonacion()
        {
            // Si no hay tipo seleccionado => ocultar campos opcionales
            if (tipoDonacionSelected == null)
            {
                txtbxDonacionMonto.Visible = false;
                cboxDonacionTipoTrans.Visible = false;
                cboxDonacionFrecuencia.Visible = false;
                cboxDonacionTipoMoneda.Visible = false;
                return;
            }

            // Uso directamente las propiedades de la entidad (son bool?)
            txtbxDonacionMonto.Visible = tipoDonacionSelected.requiereMonto ?? false;
            cboxDonacionTipoTrans.Visible = tipoDonacionSelected.requiereTipoTransaccion ?? false;
            cboxDonacionTipoMoneda.Visible = tipoDonacionSelected.requiereTipoMoneda ?? false;


            // Si oculto un control, limpio su valor para evitar datos inconsistentes al guardar
            if (!txtbxDonacionMonto.Visible) txtbxDonacionMonto.Clear();
            if (!cboxDonacionTipoTrans.Visible) cboxDonacionTipoTrans.SelectedIndex = -1;
            if (!cboxDonacionTipoMoneda.Visible) cboxDonacionTipoMoneda.SelectedIndex = -1;
        }



        private void limpiarFrom()
        {
            //limpiar el formulario

            txtbxDonacionID.Clear();
            txtbxDonacionDonanteID.Clear();
            txtbxDonacionMonto.Clear();
            txtbxDonacionObservaciones.Clear();

            cboxDonacionTipoTrans.SelectedIndex = -1;
            cboxDonacionFrecuencia.SelectedIndex = -1;
            cboxDonacionTipoMoneda.SelectedIndex = -1;

            datepkDonacionFecha.Value = DateTime.Now;
        }

        private void cargarCombo()
        {

            //cargo combo tipo transaccion
            cboxDonacionTipoTrans.DataSource = Enum.GetValues(typeof(tipoTransaccion));

            //cargo combo frecuencia
            cboxDonacionFrecuencia.DataSource = Enum.GetValues(typeof(frecuencia));

            //cargo combo tipo moneda
            cboxDonacionTipoMoneda.DataSource = Enum.GetValues(typeof(tipoMoneda));

        }

        private void btnDonacionSelectIdDonante_Click(object sender, EventArgs e)
        {
            //abro el formulario de donante lista en modo seleccion
            frmDonanteLista formularioDonanteLista = new frmDonanteLista();
            formularioDonanteLista.esSeleccion = true;
            formularioDonanteLista.ShowDialog();

            //al cerrar el formulario, verifico si se selecciono un donante
            donanteSeleccionado = formularioDonanteLista.donanteSelected;

            if (donanteSeleccionado != null)
            {
                //cargo los datos del donante seleccionado en el formulario
                txtbxDonacionDonanteID.Text = formularioDonanteLista.donanteSelected.personaId.ToString();
                tipoIdSeleccionado = formularioDonanteLista.donanteSelected.personaTipoId;

                //asocio el tipo de identificacion seleccionado con los que tengo en el enum
                string tipo = Enum.GetName(typeof(TipoIdentificacion), tipoIdSeleccionado)?.Replace("_", " ") ?? "DESCONOCIDO";
                txtbxDonacionTipoIdDonante.Text = tipo;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarDonacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (donacionSelected != null)
                {
                    var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta donación?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        donacionService.eliminar(donacionSelected.idDonacion);
                        MessageBox.Show("Donación eliminada correctamente");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la donación: " + ex.Message);
            }
        }


        private void btnGuardarDonacion_Click_1(object sender, EventArgs e)
        {


            try
            {
                if (validarCampos())
                {
                    if (donacionSelected == null)
                    {
                        clsDonacion nuevaDonacion = new clsDonacion
                        {
                            // idDonacion = int.Parse(txtbxDonacionID.Text),
                            donanteId = (txtbxDonacionDonanteID.Text),
                            donanteTipoId = tipoIdSeleccionado,
                            idTipoDonacion = tipoDonacionSelected.idTipoDonacion,
                            fechaDonacion = datepkDonacionFecha.Value,
                            monto = txtbxDonacionMonto.Visible ? decimal.Parse(txtbxDonacionMonto.Text) : (decimal?)null,
                            tipoTransaccion = (int?)(cboxDonacionTipoTrans.Visible ? (tipoTransaccion?)cboxDonacionTipoTrans.SelectedItem : null),
                            frecuencia = (int?)(cboxDonacionFrecuencia.Visible ? (frecuencia?)cboxDonacionFrecuencia.SelectedItem : null),
                            tipoMoneda = (int?)(cboxDonacionTipoMoneda.Visible ? (tipoMoneda?)cboxDonacionTipoMoneda.SelectedItem : null),
                            observaciones = txtbxDonacionObservaciones.Text,

                            estado = true
                        };

                        //llamo al servicio para crear la donacion
                        donacionService.crear(nuevaDonacion);
                        MessageBox.Show("Donación creada correctamente");
                    }
                    else
                    {
                        //actualizar la donacionSelected con los nuevos valores del formulario
                        donacionSelected.donanteId = (txtbxDonacionDonanteID.Text);
                        donacionSelected.donanteTipoId = tipoIdSeleccionado;
                        donacionSelected.idTipoDonacion = tipoDonacionSelected.idTipoDonacion;
                        donacionSelected.fechaDonacion = datepkDonacionFecha.Value;
                        donacionSelected.monto = txtbxDonacionMonto.Visible ? decimal.Parse(txtbxDonacionMonto.Text) : (decimal?)null;
                        donacionSelected.tipoTransaccion = (int?)(cboxDonacionTipoTrans.Visible ? (tipoTransaccion?)cboxDonacionTipoTrans.SelectedItem : null);
                        donacionSelected.frecuencia = (int?)(cboxDonacionFrecuencia.Visible ? (frecuencia?)cboxDonacionFrecuencia.SelectedItem : null);
                        donacionSelected.tipoMoneda = (int?)(cboxDonacionTipoMoneda.Visible ? (tipoMoneda?)cboxDonacionTipoMoneda.SelectedItem : null);
                        donacionSelected.observaciones = txtbxDonacionObservaciones.Text;

                        //llamo al servicio para modificar la donacion
                        donacionService.modificar(donacionSelected);
                        MessageBox.Show("Donación modificada correctamente");
                    }
                    //cierro el formulario
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la donación: " + ex.Message);
            }
        }

        private bool validarCampos()
        {
            //val;idar campos nulos, fecha que no sea mayor a la actual, monto positivo si es visible
            if (string.IsNullOrWhiteSpace(txtbxDonacionDonanteID.Text))
            {
                MessageBox.Show("El ID del donante es obligatorio");
                return false;
            }
            /*if (cboxDonacionIdTipoDonacion.SelectedIndex == -1)
            {
                MessageBox.Show("El tipo de donación es obligatorio");
                return false;
            }*/
            if (datepkDonacionFecha.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de donación no puede ser mayor a la fecha actual");
                return false;
            }
            // ejemplo: validar monto según requerimiento del tipo
            if ((tipoDonacionSelected?.requiereMonto ?? false))
            {
                if (string.IsNullOrWhiteSpace(txtbxDonacionMonto.Text))
                {
                    MessageBox.Show("El monto es obligatorio para este tipo de donación");
                    return false;
                }
                if (!decimal.TryParse(txtbxDonacionMonto.Text, out decimal monto) || monto <= 0)
                {
                    MessageBox.Show("El monto debe ser un número positivo");
                    return false;
                }
            }
            // validar frecuencia/transaccion/moneda usando tipoDonacionSelected?.requiere...

            //si la frecuencia, moneda o tipo de transaccion son visibles, deben estar seleccionadas
            if (cboxDonacionFrecuencia.Visible && cboxDonacionFrecuencia.SelectedIndex == -1)
            {
                MessageBox.Show("La frecuencia es obligatoria");
                return false;
            }
            if (cboxDonacionTipoMoneda.Visible && cboxDonacionTipoMoneda.SelectedIndex == -1)
            {
                MessageBox.Show("El tipo de moneda es obligatorio");
                return false;
            }
            if (cboxDonacionTipoTrans.Visible && cboxDonacionTipoTrans.SelectedIndex == -1)
            {
                MessageBox.Show("El tipo de transacción es obligatorio");
                return false;
            }

            //si pasa todas las validaciones, retorno true
            return true;
        }

        private void btnDonacionSelectIdTipoDonac_Click(object sender, EventArgs e)
        {
            // abro el formulario de tipo donacion lista en modo seleccion
            frmTipoDonacionLista formTipoDonacionLista = new frmTipoDonacionLista();
            formTipoDonacionLista.esSeleccion = true;
            formTipoDonacionLista.ShowDialog();

            // al cerrar el formulario, verifico si se selecciono un tipo de donacion
            if (formTipoDonacionLista.tipoDonacionSelected != null)
            {
                // guardo la entidad seleccionada (fuertemente tipada)
                tipoDonacionSelected = formTipoDonacionLista.tipoDonacionSelected;

                // cargo los datos del tipo de donacion seleccionado en el formulario
                txtbxDonacionIdTipoDonacion.Text = tipoDonacionSelected.idTipoDonacion.ToString();
                txtbxDonacionNombTipoDonacion.Text = tipoDonacionSelected.nombreTipoDonacion;

                // actualizo la visibilidad de los campos según las reglas del tipo
                ActualizarDatosTipoDonacion();
            }
        }

        private void txtbxDonacionDonanteID_TextChanged(object sender, EventArgs e)
        {
            activarDesactivarFrec();
        }

        private void activarDesactivarFrec()
        {
            
            if (donacionSelected.donante.tipoDonante == 1)
            {
                cboxDonacionFrecuencia.Visible = tipoDonacionSelected.requiereFrecuencia ?? false;
            }
            else
            {
                cboxDonacionFrecuencia.Visible = false;
            }

            // Si oculto un control, limpio su valor para evitar datos inconsistentes al guardar
            if (!cboxDonacionFrecuencia.Visible) cboxDonacionFrecuencia.SelectedIndex = -1;
        }
    }
}
