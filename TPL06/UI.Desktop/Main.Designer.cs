namespace Academia.UI.Desktop
{
    partial class Main
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
            this.menuLateral = new System.Windows.Forms.Panel();
            this.menuAbierto = new System.Windows.Forms.Panel();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btnModulos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarActualizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBackUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmgestionAcademia = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmgestionDocente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmgestionAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInscripcionCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAcacemia = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.menuLateral.SuspendLayout();
            this.menuAbierto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLateral
            // 
            this.menuLateral.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuLateral.Controls.Add(this.menuAbierto);
            this.menuLateral.Controls.Add(this.panel2);
            this.menuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuLateral.Location = new System.Drawing.Point(0, 0);
            this.menuLateral.Margin = new System.Windows.Forms.Padding(4);
            this.menuLateral.Name = "menuLateral";
            this.menuLateral.Size = new System.Drawing.Size(267, 554);
            this.menuLateral.TabIndex = 0;
            // 
            // menuAbierto
            // 
            this.menuAbierto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuAbierto.Controls.Add(this.btn_CerrarSesion);
            this.menuAbierto.Controls.Add(this.btnModulos);
            this.menuAbierto.Controls.Add(this.menuStrip1);
            this.menuAbierto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuAbierto.Location = new System.Drawing.Point(0, 124);
            this.menuAbierto.Margin = new System.Windows.Forms.Padding(4);
            this.menuAbierto.Name = "menuAbierto";
            this.menuAbierto.Size = new System.Drawing.Size(267, 430);
            this.menuAbierto.TabIndex = 7;
            this.menuAbierto.Visible = false;
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_CerrarSesion.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(0, 397);
            this.btn_CerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(267, 33);
            this.btn_CerrarSesion.TabIndex = 0;
            this.btn_CerrarSesion.Text = "Cerrar Sesión";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.formMain_Shown);
            // 
            // btnModulos
            // 
            this.btnModulos.FlatAppearance.BorderSize = 0;
            this.btnModulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnModulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btnModulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulos.Location = new System.Drawing.Point(25, -75);
            this.btnModulos.Margin = new System.Windows.Forms.Padding(4);
            this.btnModulos.Name = "btnModulos";
            this.btnModulos.Size = new System.Drawing.Size(267, 47);
            this.btnModulos.TabIndex = 1;
            this.btnModulos.Text = "Modulos";
            this.btnModulos.UseVisualStyleBackColor = true;
            this.btnModulos.Click += new System.EventHandler(this.btnModulos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArchivo,
            this.tsmgestionAcademia,
            this.tsmgestionDocente,
            this.tsmgestionAlumno});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(267, 126);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            this.tsmArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seguridadToolStripMenuItem,
            this.buscarActualizacionesToolStripMenuItem,
            this.backUpToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.tsmArchivo.Name = "tsmArchivo";
            this.tsmArchivo.Size = new System.Drawing.Size(261, 24);
            this.tsmArchivo.Text = "Archivo";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modulosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // modulosToolStripMenuItem
            // 
            this.modulosToolStripMenuItem.Name = "modulosToolStripMenuItem";
            this.modulosToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.modulosToolStripMenuItem.Text = "Modulos";
            this.modulosToolStripMenuItem.Click += new System.EventHandler(this.btnModulos_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // buscarActualizacionesToolStripMenuItem
            // 
            this.buscarActualizacionesToolStripMenuItem.Name = "buscarActualizacionesToolStripMenuItem";
            this.buscarActualizacionesToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.buscarActualizacionesToolStripMenuItem.Text = "Buscar Actualizaciones";
            // 
            // backUpToolStripMenuItem
            // 
            this.backUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarBackUpToolStripMenuItem,
            this.restaurarBackUpToolStripMenuItem});
            this.backUpToolStripMenuItem.Name = "backUpToolStripMenuItem";
            this.backUpToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.backUpToolStripMenuItem.Text = "BackUp";
            // 
            // realizarBackUpToolStripMenuItem
            // 
            this.realizarBackUpToolStripMenuItem.Name = "realizarBackUpToolStripMenuItem";
            this.realizarBackUpToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.realizarBackUpToolStripMenuItem.Text = "Realizar BackUp";
            // 
            // restaurarBackUpToolStripMenuItem
            // 
            this.restaurarBackUpToolStripMenuItem.Name = "restaurarBackUpToolStripMenuItem";
            this.restaurarBackUpToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.restaurarBackUpToolStripMenuItem.Text = "Restaurar BackUp";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // tsmgestionAcademia
            // 
            this.tsmgestionAcademia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.comisionesToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.especialidadesToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.planesToolStripMenuItem});
            this.tsmgestionAcademia.Name = "tsmgestionAcademia";
            this.tsmgestionAcademia.Size = new System.Drawing.Size(261, 24);
            this.tsmgestionAcademia.Text = "Gestion Academia";
            this.tsmgestionAcademia.Visible = false;
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.personasToolStripMenuItem.Text = "Personas";
            // 
            // comisionesToolStripMenuItem
            // 
            this.comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            this.comisionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.comisionesToolStripMenuItem.Text = "Comisiones";
            this.comisionesToolStripMenuItem.Click += new System.EventHandler(this.btnComisones_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.especialidadesToolStripMenuItem.Text = "Especialidades";
            this.especialidadesToolStripMenuItem.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.materiasToolStripMenuItem.Text = "Materias";
            this.materiasToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.btnMaterias_Click);
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.planesToolStripMenuItem.Text = "Planes";
            this.planesToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.btnPlanes_Click);
            // 
            // tsmgestionDocente
            // 
            this.tsmgestionDocente.Name = "tsmgestionDocente";
            this.tsmgestionDocente.Size = new System.Drawing.Size(261, 24);
            this.tsmgestionDocente.Text = "Gestion Docente";
            this.tsmgestionDocente.Visible = false;
            // 
            // tsmgestionAlumno
            // 
            this.tsmgestionAlumno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInscripcionCurso});
            this.tsmgestionAlumno.Name = "tsmgestionAlumno";
            this.tsmgestionAlumno.Size = new System.Drawing.Size(261, 24);
            this.tsmgestionAlumno.Text = "Gestion Alumno";
            this.tsmgestionAlumno.Visible = false;
            // 
            // btnInscripcionCurso
            // 
            this.btnInscripcionCurso.Name = "btnInscripcionCurso";
            this.btnInscripcionCurso.Size = new System.Drawing.Size(224, 26);
            this.btnInscripcionCurso.Text = "Inscripción a cursar";
            this.btnInscripcionCurso.Click += new System.EventHandler(this.mnuInscripcionCursos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.lblAcacemia);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 124);
            this.panel2.TabIndex = 0;
            // 
            // lblAcacemia
            // 
            this.lblAcacemia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAcacemia.AutoSize = true;
            this.lblAcacemia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcacemia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAcacemia.Location = new System.Drawing.Point(73, 92);
            this.lblAcacemia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcacemia.Name = "lblAcacemia";
            this.lblAcacemia.Size = new System.Drawing.Size(108, 25);
            this.lblAcacemia.TabIndex = 1;
            this.lblAcacemia.Text = "Academia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Academia.UI.Desktop.Properties.Resources.iconoAcademia;
            this.pictureBox1.Location = new System.Drawing.Point(73, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.lblTituloFormulario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(267, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 78);
            this.panel3.TabIndex = 1;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.AutoSize = true;
            this.lblTituloFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFormulario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloFormulario.Location = new System.Drawing.Point(20, 31);
            this.lblTituloFormulario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(78, 29);
            this.lblTituloFormulario.TabIndex = 0;
            this.lblTituloFormulario.Text = "Inicio";
            this.lblTituloFormulario.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.DarkSalmon;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(267, 78);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(800, 476);
            this.panelDesktop.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuLateral);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.pictureBox1_Click);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.menuLateral.ResumeLayout(false);
            this.menuAbierto.ResumeLayout(false);
            this.menuAbierto.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuLateral;
        private System.Windows.Forms.Button btnModulos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAcacemia;
        private System.Windows.Forms.Panel menuAbierto;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmArchivo;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarActualizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarBackUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBackUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmgestionAcademia;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmgestionDocente;
        private System.Windows.Forms.ToolStripMenuItem tsmgestionAlumno;
        private System.Windows.Forms.ToolStripMenuItem btnInscripcionCurso;
    }
}