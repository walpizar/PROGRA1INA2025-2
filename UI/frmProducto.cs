using Common.Enums;
using Common.Exceptions;
using Common.Utils;
using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Common.Enums.Enums;

namespace UI
{
    public partial class frmProducto : Form
    {

        public clsProducto productoSelected { get; set; }



        private readonly ProductoService _productoService;
        private readonly CategoriaService _CategoriaService;
        public frmProducto()
        {
            InitializeComponent();

            _productoService = new ProductoService();
            _CategoriaService  = new CategoriaService();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //validar datos de entrada
                if (true)
                {

                    //creo la instancia del producto nuevo, 
                    clsProducto producto = productoSelected == null ? new clsProducto() : productoSelected;

                    /* if (productoSelected == null)
                     {
                         producto = new clsProducto();
                     }
                     else
                     {
                         producto = productoSelected;
                     }*/
                    //seteo los valores del producto

                    //clsMedico medico = new clsMedico();
                    //medico.Especialidad = 343243;

                    //clsPersona persona = new clsPersona();
                    //persona.nombre = "Juan";
                    //persona.apellido1 = "Perez"; 

                    //medico.Persona = persona;



                    producto.id = Convert.ToInt32(txtId.Text);
                    // producto.id = int.Parse(txtId.Text);
                    producto.nombre = txtNombre.Text;
                    producto.precio = Convert.ToInt32(txtPrecio.Text);
                    producto.cantidad = (int)txtCantidad.Value;

                    producto.familia = (int)cboFamilia.SelectedItem;
                    producto.CategoriaId = (int)cboCategoria.SelectedValue;



                    //llamo a mi capa de servicios para guardar/ crear el producto
                    if (productoSelected == null)
                    {
                        _productoService.crear(producto);
                        //muestro mensaje de exito
                        MessageBox.Show("Producto creado correctamente");
                    }
                    else
                    {
                        _productoService.modificar(producto);
                        //muestro mensaje de exito
                        MessageBox.Show("Producto modificado correctamente");
                    }


                    //limpio los campos
                    limpiarForm(); //ya no tiene duncionalidad xq se cierra el form
                    this.Close();

                }

            }
            catch (EntityExistDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NameProductExistDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (PriceNegativeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido. Contante con el administrador.");
            }

        }

        private void limpiarForm()
        {
            txtId.ResetText();
            txtNombre.ResetText();
            txtPrecio.ResetText();
            txtCantidad.Value = 0;
        }

        private bool validarDatos()
        {
            //validaciones de datos de entrada
            if (txtId.Text.Length == 0)
            {
                MessageBox.Show("El id es obligatorio");
                txtId.Focus();
                return false;
            }

            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("El nombre es obligatorio");
                txtNombre.Focus();
                return false;

            }
            if (txtPrecio.Text.Length == 0 || !Validator.IsDecimal(txtPrecio.Text) || decimal.Parse(txtPrecio.Text) <= 0)
            {
                MessageBox.Show("El precio es obligatorio y debe ser mayor a 0");
                txtPrecio.Focus();
                return false;
            }
            if (txtCantidad.Value < 0)
            {
                MessageBox.Show("La cantidad debe ser mayor o igual a 0");
                txtCantidad.Focus();
                return false;

            }


            return true;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            cargarCombos();
            if (productoSelected != null) //accion de modificar
            {
                this.lblTitulo.Text = "Modificar Producto";
                this.Text = "Modificar Producto";
                this.txtId.Enabled = false; //no se puede modificar el id
                btnGuardar.Text = "Modificar";
                btnEliminar.Visible = true; //muestro el boton de eliminar
                cargarForm();

            }
            else //producto es null, accion es crear
            {
                this.lblTitulo.Text = "Crear Producto";
                this.Text = "Crear Producto";
                this.txtId.Enabled = true; //se puede ingresar el id
                btnGuardar.Text = "Guardar";
                btnEliminar.Visible = false; //oculto el boton de eliminar
                limpiarForm();
            }

          



        }

        private void cargarCombos()
        {
            //cargar el combo de las familiar con el enumerador definido
            cboFamilia.DataSource = Enum.GetValues(typeof(Enums.FamiliaProducto));

            //cargar el combo de las cateogiras
            //dessde la base datos.
            //obtengo las categorias de la base de datos        
            List<clsCategoria> listaCat = _CategoriaService.consultarTodos();

            //cargo el combo de categorias
            cboCategoria.DataSource = listaCat;
            cboCategoria.DisplayMember = "display"; //lo que se muestra
            cboCategoria.ValueMember = "Id"; //el valor real




        }

        //carga el form con lo datos pasados por la propiedad
        private void cargarForm()
        {
            txtId.Text = productoSelected.id.ToString();
            txtNombre.Text = productoSelected.nombre;
            txtPrecio.Text = productoSelected.precio.ToString();
            txtCantidad.Value = productoSelected.cantidad;
            //obtiene el valor que el usuario selecciono en el combo
            cboFamilia.SelectedItem = (FamiliaProducto)productoSelected.familia;
            cboCategoria.SelectedValue = (int)productoSelected.CategoriaId;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

               DialogResult resp = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Confirmación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resp == DialogResult.Yes)
                {
                    //_productoService.eliminar(productoSelected.id);
                    MessageBox.Show("Producto eliminado correctamente");
                    this.Close(); //cierro el formulario
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar el producto.");
            }



        }
    }
}
