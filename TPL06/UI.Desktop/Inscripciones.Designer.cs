namespace Academia.UI.Desktop
{
    partial class Inscripciones
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvAlumnoInscripciones = new System.Windows.Forms.DataGridView();
            this.CursoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CondicionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tlAlumnoInscripciones = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbCrearAlumnoInscripciones = new System.Windows.Forms.ToolStripButton();
            this.tsbModificarAlumnoInscripciones = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminarAlumnoInscripciones = new System.Windows.Forms.ToolStripButton();
            this.tsbReporte = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoInscripciones)).BeginInit();
            this.tlAlumnoInscripciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCrearAlumnoInscripciones,
            this.tsbModificarAlumnoInscripciones,
            this.tsbEliminarAlumnoInscripciones,
            this.tsbReporte});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvAlumnoInscripciones
            // 
            this.dgvAlumnoInscripciones.AllowUserToAddRows = false;
            this.dgvAlumnoInscripciones.AllowUserToDeleteRows = false;
            this.dgvAlumnoInscripciones.AllowUserToResizeColumns = false;
            this.dgvAlumnoInscripciones.AllowUserToResizeRows = false;
            this.dgvAlumnoInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CursoColumn,
            this.CondicionColumn,
            this.NotaColumn});
            this.dgvAlumnoInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnoInscripciones.Location = new System.Drawing.Point(0, 27);
            this.dgvAlumnoInscripciones.Name = "dgvAlumnoInscripciones";
            this.dgvAlumnoInscripciones.ReadOnly = true;
            this.dgvAlumnoInscripciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAlumnoInscripciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAlumnoInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnoInscripciones.Size = new System.Drawing.Size(600, 339);
            this.dgvAlumnoInscripciones.TabIndex = 2;
            // 
            // CursoColumn
            // 
            this.CursoColumn.DataPropertyName = "Curso";
            this.CursoColumn.HeaderText = "Curso";
            this.CursoColumn.MinimumWidth = 6;
            this.CursoColumn.Name = "CursoColumn";
            this.CursoColumn.ReadOnly = true;
            this.CursoColumn.Width = 200;
            // 
            // CondicionColumn
            // 
            this.CondicionColumn.DataPropertyName = "Condicion";
            this.CondicionColumn.HeaderText = "Condicion";
            this.CondicionColumn.MinimumWidth = 6;
            this.CondicionColumn.Name = "CondicionColumn";
            this.CondicionColumn.ReadOnly = true;
            this.CondicionColumn.Width = 125;
            // 
            // NotaColumn
            // 
            this.NotaColumn.DataPropertyName = "Nota";
            this.NotaColumn.HeaderText = "Nota";
            this.NotaColumn.MinimumWidth = 6;
            this.NotaColumn.Name = "NotaColumn";
            this.NotaColumn.ReadOnly = true;
            this.NotaColumn.Width = 125;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnActualizar.Location = new System.Drawing.Point(441, 313);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(522, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tlAlumnoInscripciones
            // 
            this.tlAlumnoInscripciones.ColumnCount = 2;
            this.tlAlumnoInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAlumnoInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlAlumnoInscripciones.Controls.Add(this.dataGridView1, 0, 0);
            this.tlAlumnoInscripciones.Controls.Add(this.btnActualizar, 0, 1);
            this.tlAlumnoInscripciones.Controls.Add(this.btnSalir, 1, 1);
            this.tlAlumnoInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlAlumnoInscripciones.Location = new System.Drawing.Point(0, 27);
            this.tlAlumnoInscripciones.Name = "tlAlumnoInscripciones";
            this.tlAlumnoInscripciones.RowCount = 2;
            this.tlAlumnoInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAlumnoInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAlumnoInscripciones.Size = new System.Drawing.Size(600, 339);
            this.tlAlumnoInscripciones.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tlAlumnoInscripciones.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(594, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Curso";
            this.dataGridViewTextBoxColumn1.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Condicion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Condicion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nota";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nota";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // tsbCrearAlumnoInscripciones
            // 
            this.tsbCrearAlumnoInscripciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCrearAlumnoInscripciones.Image = global::Academia.UI.Desktop.Properties.Resources.add_btn;
            this.tsbCrearAlumnoInscripciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCrearAlumnoInscripciones.Name = "tsbCrearAlumnoInscripciones";
            this.tsbCrearAlumnoInscripciones.Size = new System.Drawing.Size(24, 24);
            this.tsbCrearAlumnoInscripciones.Text = "Nuevo";
            this.tsbCrearAlumnoInscripciones.Click += new System.EventHandler(this.tsbCrearAlumnoInscripciones_Click);
            // 
            // tsbModificarAlumnoInscripciones
            // 
            this.tsbModificarAlumnoInscripciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificarAlumnoInscripciones.Image = global::Academia.UI.Desktop.Properties.Resources.edit_btn;
            this.tsbModificarAlumnoInscripciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificarAlumnoInscripciones.Name = "tsbModificarAlumnoInscripciones";
            this.tsbModificarAlumnoInscripciones.Size = new System.Drawing.Size(24, 24);
            this.tsbModificarAlumnoInscripciones.Text = "Editar";
            this.tsbModificarAlumnoInscripciones.Click += new System.EventHandler(this.tsbModificarAlumnoInscripciones_Click);
            // 
            // tsbEliminarAlumnoInscripciones
            // 
            this.tsbEliminarAlumnoInscripciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminarAlumnoInscripciones.Image = global::Academia.UI.Desktop.Properties.Resources.remove_btn;
            this.tsbEliminarAlumnoInscripciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminarAlumnoInscripciones.Name = "tsbEliminarAlumnoInscripciones";
            this.tsbEliminarAlumnoInscripciones.Size = new System.Drawing.Size(24, 24);
            this.tsbEliminarAlumnoInscripciones.Text = "Eliminar";
            this.tsbEliminarAlumnoInscripciones.Click += new System.EventHandler(this.tsbEliminarAlumnoInscripciones_Click);
            // 
            // tsbReporte
            // 
            this.tsbReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReporte.Image = global::Academia.UI.Desktop.Properties.Resources.report_btn;
            this.tsbReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReporte.Name = "tsbReporte";
            this.tsbReporte.Size = new System.Drawing.Size(24, 24);
            this.tsbReporte.Text = "toolStripButton1";
            this.tsbReporte.Click += new System.EventHandler(this.tsbReporte_Click);
            // 
            // Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tlAlumnoInscripciones);
            this.Controls.Add(this.dgvAlumnoInscripciones);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inscripciones";
            this.Text = "Inscripciones";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoInscripciones)).EndInit();
            this.tlAlumnoInscripciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCrearAlumnoInscripciones;
        private System.Windows.Forms.ToolStripButton tsbModificarAlumnoInscripciones;
        private System.Windows.Forms.ToolStripButton tsbEliminarAlumnoInscripciones;
        private System.Windows.Forms.DataGridView dgvAlumnoInscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondicionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotaColumn;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TableLayoutPanel tlAlumnoInscripciones;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton tsbReporte;
    }
}