
namespace GenerarArchivo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbComentario = new System.Windows.Forms.TextBox();
            this.btnAgregarValoracion = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnExportar = new System.Windows.Forms.Button();
            this.nupValoracion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nupValoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbComentario
            // 
            this.tbComentario.Location = new System.Drawing.Point(75, 65);
            this.tbComentario.Multiline = true;
            this.tbComentario.Name = "tbComentario";
            this.tbComentario.Size = new System.Drawing.Size(475, 170);
            this.tbComentario.TabIndex = 0;
            // 
            // btnAgregarValoracion
            // 
            this.btnAgregarValoracion.Location = new System.Drawing.Point(556, 19);
            this.btnAgregarValoracion.Name = "btnAgregarValoracion";
            this.btnAgregarValoracion.Size = new System.Drawing.Size(111, 55);
            this.btnAgregarValoracion.TabIndex = 2;
            this.btnAgregarValoracion.Text = "Agregar Valoración";
            this.btnAgregarValoracion.UseVisualStyleBackColor = true;
            this.btnAgregarValoracion.Click += new System.EventHandler(this.btnAgregarValoracion_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(556, 287);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(111, 51);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar todas las valoraciones";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // nupValoracion
            // 
            this.nupValoracion.Location = new System.Drawing.Point(75, 14);
            this.nupValoracion.Name = "nupValoracion";
            this.nupValoracion.Size = new System.Drawing.Size(120, 20);
            this.nupValoracion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valoración";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comentario";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(77, 39);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(473, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(241, 258);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(69, 68);
            this.btnCargarImagen.TabIndex = 10;
            this.btnCargarImagen.Text = "Agregar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(75, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupValoracion);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnAgregarValoracion);
            this.Controls.Add(this.tbComentario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupValoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbComentario;
        private System.Windows.Forms.Button btnAgregarValoracion;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.NumericUpDown nupValoracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

