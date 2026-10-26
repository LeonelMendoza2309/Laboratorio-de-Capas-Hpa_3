namespace Presentación
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblBienvenida = new Label();
            lblBienUser = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(lblBienUser);
            panel1.Controls.Add(lblBienvenida);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 100);
            panel1.TabIndex = 0;
            panel1.TabStop = true;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Lucida Bright", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(36, 36);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(171, 32);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido:";
            // 
            // lblBienUser
            // 
            lblBienUser.AutoSize = true;
            lblBienUser.Font = new Font("Lucida Bright", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBienUser.Location = new Point(213, 36);
            lblBienUser.Name = "lblBienUser";
            lblBienUser.Size = new Size(119, 32);
            lblBienUser.TabIndex = 1;
            lblBienUser.Text = "Usuario";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 371);
            Controls.Add(panel1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblBienUser;
        private Label lblBienvenida;
    }
}