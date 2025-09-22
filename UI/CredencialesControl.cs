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
    public partial class CredencialesControl : UserControl
    {
        public CredencialesControl()
        {
            InitializeComponent();
        }

        public string Usuario
        {
            get { return txtUsuario.Text; }
            set { txtUsuario.Text = value; }
        }

        public string Contrasena
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string Rol
        {
            get { return combRol.SelectedItem?.ToString(); }
            set { combRol.SelectedItem = value; }
        }

    }
}
