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

namespace UI
{
    public partial class frmTipoDonacion : Form
    {
        //AGREGOP PARAMETRO CLSTIPODONACION
        public clsTipoDonacion tipoDonacionSelected { get; set; }

        //llamo al service
        tipoDonacionService tipoDonacionService;

        public frmTipoDonacion()
        {
            //instancio el service
            tipoDonacionService = new tipoDonacionService();

            InitializeComponent();
        }

        private void frmTipoDonacion_Load(object sender, EventArgs e)
        {
            //procedemos a modificar o crear
            if (tipoDonacionSelected != null)
            {
                //modo modificacion
                this.Text = "MODIFICAR TIPO DE DONACIÓN";
                this.lblCrearTipoDonacion.Text = "MODIFICAR TIPO DE DONACIÓN";
                this.txtbxTipoDonacionID.Enabled = false; //no se puede modificar el id
                this.btnEliminarDonacion.Visible = true; //muestro el boton eliminar
                this.btnGuardarDonacion.Text = "MODIFICAR";
                
                //cargo los datos en el formulario
                cargarFormModificarDonacion();


            }
            else
            {
                //modo creacion
                this.txtbxTipoDonacionID.Enabled = false;
                this.btnEliminarDonacion.Visible = false; //oculto el boton eliminar

                //se limpia el formulario
                limpiarform();

                //obtengo el siguiente id
                int siguienteID = ObtenerSiguienteID();
                txtbxTipoDonacionID.Text = siguienteID.ToString();
            }

        }
        private int ObtenerSiguienteID()
        {
            try
            {
                //consulto todos los tipos de donacion y obtengo el maximo id + 1
                var tipoDonacionList = tipoDonacionService.consultarTodos();
                if (tipoDonacionList.Count == 0)
                {
                    return 1; //si no hay registros, el siguiente id es 1
                }
                else
                {
                    return tipoDonacionList.Max(t => t.idTipoDonacion) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el siguiente ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; //en caso de error retorno 0
            }
        }

        private void cargarFormModificarDonacion()
        {
            txtbxTipoDonacionID.Text = tipoDonacionSelected.idTipoDonacion.ToString();
            txtbxTipoDonacionID.Enabled = false; //no se puede modificar el id
            txtbxTipoDonacionNombre.Text = tipoDonacionSelected.nombreTipoDonacion;
            txtbxTipoDonacionDescripcion.Text = tipoDonacionSelected.descripcion;
        }

        private void limpiarform()
        {
            //limpiar el formulario tipodonacion los campos editables
            txtbxTipoDonacionID.ResetText();
            txtbxTipoDonacionNombre.ResetText();
            txtbxTipoDonacionDescripcion.ResetText();

            //FOCUS EN ID
            txtbxTipoDonacionID.Focus();

        }

        private void btnGuardarDonacion_Click(object sender, EventArgs e)
        {
            //guardar o modificar el tipo de donacion
            try
            {
                if (hacerValidaciones())
                {
                    if (tipoDonacionSelected == null)
                    {
                        //modo creacion
                        clsTipoDonacion nuevoTipoDonacion = new clsTipoDonacion
                        {
                            //idTipoDonacion = int.Parse(txtbxTipoDonacionID.Text),
                            nombreTipoDonacion = txtbxTipoDonacionNombre.Text,
                            descripcion = txtbxTipoDonacionDescripcion.Text,

                            //valido si el nombre es dinero y confirmo los requerimientos, sino los dejo en false
                            requiereMonto = (txtbxTipoDonacionNombre.Text.ToLower() == "dinero") ? true : false,
                            requiereTipoTransaccion = (txtbxTipoDonacionNombre.Text.ToLower() == "dinero") ? true : false,
                            requiereFrecuencia = (txtbxTipoDonacionNombre.Text.ToLower() == "dinero") ? true : false,
                            requiereTipoMoneda = (txtbxTipoDonacionNombre.Text.ToLower() == "dinero") ? true : false,

                        };

                        //llamo al service para crear
                        tipoDonacionService.crear(nuevoTipoDonacion);
                        MessageBox.Show("Tipo de donación creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //cierro el formulario
                        this.Close();
                    }
                    else
                    {
                        //modo modificacion
                        tipoDonacionSelected.nombreTipoDonacion = txtbxTipoDonacionNombre.Text;
                        tipoDonacionSelected.descripcion = txtbxTipoDonacionDescripcion.Text;
                        //llamo al service para modificar
                        tipoDonacionService.modificar(tipoDonacionSelected);
                        MessageBox.Show("Tipo de donación modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //cierro el formulario
                        this.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el tipo de donación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cierro el formulario
            this.Close();
        }

        private void btnEliminarDonacion_Click(object sender, EventArgs e)
        {
            //elimino el tipo de donacion
            try
            {
                //confirmo la eliminacion
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este tipo de donación?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    //llamo al service para eliminar
                    tipoDonacionService.eliminar(tipoDonacionSelected.idTipoDonacion.ToString());
                    MessageBox.Show("Tipo de donación eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //cierro el formulario
                    this.Close();

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el tipo de donación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool hacerValidaciones()
        {
            //validar campos en blanco
            if (string.IsNullOrWhiteSpace(txtbxTipoDonacionNombre.Text)) 
            {
                MessageBox.Show("El nombre del tipo de donación es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtbxTipoDonacionDescripcion.Text))
            {
                MessageBox.Show("La descripcion es obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
