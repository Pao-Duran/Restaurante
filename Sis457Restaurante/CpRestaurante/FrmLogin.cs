using ClnRestaurante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpRestaurante
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        //private bool validar()
        //{
        //    bool esValido = true;
        //    erpUsuario.SetError(txtUsuario, "");
        //    erpClave.SetError(txtClave, "");

        //    if (string.IsNullOrEmpty(txtUsuario.Text))
        //    {
        //        erpUsuario.SetError(txtUsuario, "El campo usuario es obligatorio");
        //        esValido = false;
        //    }
        //    if (string.IsNullOrEmpty(txtClave.Text))
        //    {
        //        erpClave.SetError(txtClave, "El campo contraseña es obligatorio");
        //        esValido = false;
        //    }
        //    return esValido;
        //}

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            new frmPrincipal().ShowDialog();
            //if (validar())
            //{
            //    var usuarios = UsuarioCln.validar(txtUsuario.Text, Util.Encrypt(txtClave.Text));
            //    if (usuarios != null)
            //    {
            //        Util.usuario = usuarios;
            //        txtClave.Text = string.Empty;
            //        txtUsuario.Focus();
            //        txtUsuario.SelectAll();
            //        this.Visible = false;
            //        new frmPrincipal().ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario y/o contraseña incorrecto", "::: Error - Restaurante:::",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) txtClave.Focus();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnIngresar.PerformClick();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            new FrmUsuario().ShowDialog();
        }
    }
}
