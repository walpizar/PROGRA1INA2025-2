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

namespace UI
{
    public partial class frmProducto : Form
    {


        private readonly ProductoService _productoService;
        public frmProducto(ProductoService _proServ)
        {
            InitializeComponent();

            _productoService = _proServ;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            try
            {
                //validar datos de entrada
                if (validarDatos())
                {

                    //creo la instancia del producto nuevo
                    clsProducto producto = new clsProducto();

                    //seteo los valores del producto
                    producto.id = Convert.ToInt32(txtId.Text);
                    // producto.id = int.Parse(txtId.Text);
                    producto.setNombre(txtNombre.Text);
                    producto.precio = Convert.ToInt32(txtPrecio.Text);
                    producto.cantidad = (int)txtCantidad.Value;

                    //llamo a mi capa de servicios para guardar/ crear el producto
                    _productoService.crear(producto);
                    //muestro mensaje de exito
                    MessageBox.Show("Producto creado correctamente");
                    //limpio los campos
                    limpiarForm();

                }







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            if (txtNombre.Text.Length == 0 || txtNombre.Text.Length < 5)
            {
                MessageBox.Show("El nombre es obligatorio y debe tener mas de 5 caracteres");
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

        }
    }
}
