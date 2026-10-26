using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentación
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        public frmPrincipal(string usuario) : this()
        {
            if (!string.IsNullOrEmpty(usuario))
            {
                lblBienUser.Text = usuario;
            }
        }
    }
}
