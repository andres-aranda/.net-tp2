namespace Academia.UI.Desktop
{
    partial class MisCursosAlumno
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
            this.inscripcionesAlu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionesAlu)).BeginInit();
            this.SuspendLayout();
            // 
            // inscripcionesAlu
            // 
            this.inscripcionesAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inscripcionesAlu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inscripcionesAlu.Location = new System.Drawing.Point(0, 0);
            this.inscripcionesAlu.Name = "inscripcionesAlu";
            this.inscripcionesAlu.Size = new System.Drawing.Size(800, 450);
            this.inscripcionesAlu.TabIndex = 0;
            // 
            // MisCursosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inscripcionesAlu);
            this.Name = "MisCursosAlumno";
            this.Text = "MisCursosAlumno";
            this.Load += new System.EventHandler(this.MisCursosAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionesAlu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inscripcionesAlu;
    }
}