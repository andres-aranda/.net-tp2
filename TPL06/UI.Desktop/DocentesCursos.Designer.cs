namespace Academia.UI.Desktop
{
    partial class DocentesCursos
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
            this.dgvCursosDocente = new System.Windows.Forms.DataGridView();
            this.tsmCursosDocente = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).BeginInit();
            this.tsmCursosDocente.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCursosDocente
            // 
            this.dgvCursosDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCursosDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosDocente.Location = new System.Drawing.Point(0, 28);
            this.dgvCursosDocente.Name = "dgvCursosDocente";
            this.dgvCursosDocente.Size = new System.Drawing.Size(800, 243);
            this.dgvCursosDocente.TabIndex = 0;
            // 
            // tsmCursosDocente
            // 
            this.tsmCursosDocente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsmCursosDocente.Location = new System.Drawing.Point(0, 0);
            this.tsmCursosDocente.Name = "tsmCursosDocente";
            this.tsmCursosDocente.Size = new System.Drawing.Size(800, 25);
            this.tsmCursosDocente.TabIndex = 1;
            this.tsmCursosDocente.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = global::Academia.UI.Desktop.Properties.Resources.add_btn;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::Academia.UI.Desktop.Properties.Resources.edit_btn;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "tsbEditar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::Academia.UI.Desktop.Properties.Resources.remove_btn;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "tsbEliminar";
            // 
            // DocentesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 271);
            this.Controls.Add(this.tsmCursosDocente);
            this.Controls.Add(this.dgvCursosDocente);
            this.Name = "DocentesCursos";
            this.Text = "Mis cursos";
            this.Load += new System.EventHandler(this.DocentesCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosDocente)).EndInit();
            this.tsmCursosDocente.ResumeLayout(false);
            this.tsmCursosDocente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursosDocente;
        private System.Windows.Forms.ToolStrip tsmCursosDocente;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}