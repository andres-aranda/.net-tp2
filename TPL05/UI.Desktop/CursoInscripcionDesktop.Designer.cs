namespace Academia.UI.Desktop
{
    partial class CursoInscripcionDesktop
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tlCursoInscripcion = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.tlCursoInscripcion.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(106, 26);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(52, 17);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Cursos";
            // 
            // cboCursos
            // 
            this.cboCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlCursoInscripcion.SetColumnSpan(this.cboCursos, 3);
            this.cboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(166, 22);
            this.cboCursos.Margin = new System.Windows.Forms.Padding(4);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(626, 24);
            this.cboCursos.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Location = new System.Drawing.Point(131, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 33);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAceptar.Location = new System.Drawing.Point(0, 0);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 33);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tlCursoInscripcion
            // 
            this.tlCursoInscripcion.AutoSize = true;
            this.tlCursoInscripcion.ColumnCount = 4;
            this.tlCursoInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlCursoInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlCursoInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlCursoInscripcion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlCursoInscripcion.Controls.Add(this.lblCurso, 0, 0);
            this.tlCursoInscripcion.Controls.Add(this.cboCursos, 1, 0);
            this.tlCursoInscripcion.Controls.Add(this.pnlBotones, 3, 1);
            this.tlCursoInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCursoInscripcion.Location = new System.Drawing.Point(0, 0);
            this.tlCursoInscripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tlCursoInscripcion.Name = "tlCursoInscripcion";
            this.tlCursoInscripcion.Padding = new System.Windows.Forms.Padding(4);
            this.tlCursoInscripcion.RowCount = 2;
            this.tlCursoInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCursoInscripcion.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCursoInscripcion.Size = new System.Drawing.Size(800, 111);
            this.tlCursoInscripcion.TabIndex = 1;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.btnAceptar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(561, 70);
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(231, 33);
            this.pnlBotones.TabIndex = 2;
            // 
            // CursoInscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 111);
            this.Controls.Add(this.tlCursoInscripcion);
            this.Name = "CursoInscripcionDesktop";
            this.Text = "Inscripcion a Curso";
            this.tlCursoInscripcion.ResumeLayout(false);
            this.tlCursoInscripcion.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cboCursos;
        private System.Windows.Forms.TableLayoutPanel tlCursoInscripcion;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}