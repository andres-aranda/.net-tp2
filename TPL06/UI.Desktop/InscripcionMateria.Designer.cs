namespace Academia.UI.Desktop
{
    partial class InscripcionMateria
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
            this.cmbIdMaterias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIdMaterias
            // 
            this.cmbIdMaterias.FormattingEnabled = true;
            this.cmbIdMaterias.Location = new System.Drawing.Point(81, 27);
            this.cmbIdMaterias.Name = "cmbIdMaterias";
            this.cmbIdMaterias.Size = new System.Drawing.Size(173, 21);
            this.cmbIdMaterias.TabIndex = 0;
            this.cmbIdMaterias.SelectedIndexChanged += new System.EventHandler(this.cmbIdMaterias_SelectedIndexChanged);
            this.cmbIdMaterias.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materia:";
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.DescripcionComision,
            this.AñoEspecialidad});
            this.dgvCursos.Location = new System.Drawing.Point(33, 94);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(434, 200);
            this.dgvCursos.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inscribirse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(30, 63);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(149, 13);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "Selecciones el curso deseado";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcin";
            this.Descripcion.Name = "Descripcion";
            // 
            // DescripcionComision
            // 
            this.DescripcionComision.DataPropertyName = "Business.Entities.Comision.DescripcionComision";
            this.DescripcionComision.HeaderText = "Comision";
            this.DescripcionComision.Name = "DescripcionComision";
            // 
            // AñoEspecialidad
            // 
            this.AñoEspecialidad.DataPropertyName = "Comision.AñoEspecialidad";
            this.AñoEspecialidad.HeaderText = "Año de la carrera";
            this.AñoEspecialidad.Name = "AñoEspecialidad";
            // 
            // InscripcionMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 473);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIdMaterias);
            this.Name = "InscripcionMateria";
            this.Text = "InscripcionMateria";
            this.Load += new System.EventHandler(this.InscripcionMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIdMaterias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoEspecialidad;
    }
}