namespace Academia.UI.Desktop
{
    partial class Alumno
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
            this.dvgAlumnos = new System.Windows.Forms.DataGridView();
            this.IdInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgAlumnos
            // 
            this.dvgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInscripcion,
            this.Año,
            this.Materias,
            this.Comision,
            this.Nombre,
            this.Apellido,
            this.Legajo,
            this.Calificar,
            this.Condicion});
            this.dvgAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgAlumnos.Location = new System.Drawing.Point(0, 0);
            this.dvgAlumnos.Name = "dvgAlumnos";
            this.dvgAlumnos.Size = new System.Drawing.Size(844, 450);
            this.dvgAlumnos.TabIndex = 0;
            this.dvgAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAlumnos_CellContentClick);
            // 
            // IdInscripcion
            // 
            this.IdInscripcion.DataPropertyName = "IdInscripcion";
            this.IdInscripcion.HeaderText = "IdInscripcion";
            this.IdInscripcion.Name = "IdInscripcion";
            // 
            // Año
            // 
            this.Año.DataPropertyName = "Año";
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            // 
            // Materias
            // 
            this.Materias.DataPropertyName = "Materia";
            this.Materias.HeaderText = "Materias";
            this.Materias.Name = "Materias";
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "Comision";
            this.Comision.HeaderText = "Comision";
            this.Comision.Name = "Comision";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apelllido";
            this.Apellido.Name = "Apellido";
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            // 
            // Calificar
            // 
            this.Calificar.DataPropertyName = "Nota";
            this.Calificar.HeaderText = "Calificar";
            this.Calificar.Name = "Calificar";
            // 
            // Condicion
            // 
            this.Condicion.DataPropertyName = "Condicion";
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.dvgAlumnos);
            this.Name = "Alumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewButtonColumn Calificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
    }
}