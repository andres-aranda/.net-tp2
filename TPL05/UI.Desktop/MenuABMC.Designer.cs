namespace Academia.UI.Desktop
{
    partial class MenuABMC
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnModulos = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú temporario para probar el listado,\r\ncreación, actualización, y eliminación d" +
    "e los siguientes datos:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.Location = new System.Drawing.Point(15, 38);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(289, 23);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaterias.Location = new System.Drawing.Point(15, 67);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(289, 23);
            this.btnMaterias.TabIndex = 2;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEspecialidades.Location = new System.Drawing.Point(15, 96);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(289, 23);
            this.btnEspecialidades.TabIndex = 3;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnModulos
            // 
            this.btnModulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModulos.Location = new System.Drawing.Point(15, 125);
            this.btnModulos.Name = "btnModulos";
            this.btnModulos.Size = new System.Drawing.Size(289, 23);
            this.btnModulos.TabIndex = 4;
            this.btnModulos.Text = "Módulos";
            this.btnModulos.UseVisualStyleBackColor = true;
            this.btnModulos.Click += new System.EventHandler(this.btnModulos_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanes.Location = new System.Drawing.Point(15, 154);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(289, 23);
            this.btnPlanes.TabIndex = 5;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // MenuABMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 192);
            this.Controls.Add(this.btnPlanes);
            this.Controls.Add(this.btnModulos);
            this.Controls.Add(this.btnEspecialidades);
            this.Controls.Add(this.btnMaterias);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuABMC";
            this.Text = "Academia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnModulos;
        private System.Windows.Forms.Button btnPlanes;
    }
}