using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Datos;

namespace Presentación

{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string strUsuario = txtUsuario.Text.Trim();
            string strPassword = txtContraseña.Text.Trim();
            E_Usuario usuario = N_Usuario.Login(strUsuario, strPassword);
            if (usuario != null && usuario.ID > 0)
            {
                
                MessageBox.Show("¡Bienvenido, " + usuario.dsUsuario + "!", "Login Exitoso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); 
                frmPrincipal principalForm = new frmPrincipal(usuario.dsUsuario);
                principalForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

