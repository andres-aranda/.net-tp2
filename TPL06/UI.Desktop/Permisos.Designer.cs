namespace Academia.UI.Desktop
{
    partial class Permisos
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
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esDocente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esAlumno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esNoDocente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.esAdministrador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreUsuario,
            this.esDocente,
            this.esAlumno,
            this.esNoDocente,
            this.esAdministrador});
            this.dgvPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPermisos.Location = new System.Drawing.Point(0, 0);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(730, 332);
            this.dgvPermisos.TabIndex = 0;
            this.dgvPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisos_CellContentClick);
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.DataPropertyName = "NombreUsuario";
            this.nombreUsuario.HeaderText = "Usuario";
            this.nombreUsuario.Name = "nombreUsuario";
            // 
            // esDocente
            // 
            this.esDocente.HeaderText = "Docente";
            this.esDocente.Name = "esDocente";
            // 
            // esAlumno
            // 
            this.esAlumno.HeaderText = "Alumno";
            this.esAlumno.Name = "esAlumno";
            // 
            // esNoDocente
            // 
            this.esNoDocente.HeaderText = "No docente";
            this.esNoDocente.Name = "esNoDocente";
            // 
            // esAdministrador
            // 
            this.esAdministrador.HeaderText = "Administrador";
            this.esAdministrador.Name = "esAdministrador";
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 332);
            this.Controls.Add(this.dgvPermisos);
            this.Name = "Permisos";
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esDocente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esAlumno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esNoDocente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn esAdministrador;
    }
}