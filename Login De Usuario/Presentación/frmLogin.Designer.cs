namespace Presentación
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pbImage = new PictureBox();
            pbLog = new PictureBox();
            btnIniciarSesion = new Button();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelRight = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLog).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 1;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Size = new Size(725, 363);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // pbImage
            // 
            pbImage.Dock = DockStyle.Fill;
            pbImage.Image = (Image)resources.GetObject("pbImage.Image");
            pbImage.Name = "pbImage";
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // tableLayoutPanelRight
            // 
            tableLayoutPanelRight.ColumnCount = 1;
            tableLayoutPanelRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelRight.Dock = DockStyle.Fill;
            tableLayoutPanelRight.Location = new Point(362, 3);
            tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            tableLayoutPanelRight.RowCount = 6;
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelRight.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanelRight.Size = new Size(360, 357);
            tableLayoutPanelRight.TabIndex = 1;
            // 
            // pbLog
            // 
            pbLog.Image = (Image)resources.GetObject("pbLog.Image");
            pbLog.SizeMode = PictureBoxSizeMode.Zoom;
            pbLog.Dock = DockStyle.Fill;
            pbLog.Name = "pbLog";
            pbLog.TabIndex = 1;
            pbLog.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Anchor = AnchorStyles.Left;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Width = 200;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Anchor = AnchorStyles.Left;
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Anchor = AnchorStyles.None;
            btnIniciarSesion.BackColor = SystemColors.GradientActiveCaption;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // Add controls to layout
            // 
            tableLayoutPanelRight.Controls.Add(pbLog, 0, 0);
            tableLayoutPanelRight.Controls.Add(lblUsuario, 0, 1);
            tableLayoutPanelRight.Controls.Add(txtUsuario, 0, 2);
            tableLayoutPanelRight.Controls.Add(lblContraseña, 0, 3);
            tableLayoutPanelRight.Controls.Add(txtContraseña, 0, 4);
            tableLayoutPanelRight.Controls.Add(btnIniciarSesion, 0, 5);
            tableLayoutPanelMain.Controls.Add(pbImage, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelRight, 1, 0);
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(725, 363);
            Controls.Add(tableLayoutPanelMain);
            Name = "frmLogin";
            Text = "Inicio de Sesión:";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbImage;
        private PictureBox pbLog;
        private Button btnIniciarSesion;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelRight;
    }
}