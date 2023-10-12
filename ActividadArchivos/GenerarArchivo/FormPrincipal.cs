using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenerarArchivo.Models;

namespace GenerarArchivo
{
    public partial class Form1 : Form
    {
        List<Calificacion> calificaciones = new List<Calificacion>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarValoracion_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int puntuacion = Convert.ToInt32(nupValoracion.Value);
            string contenido = tbComentario.Text.Replace("\r","").Replace("\n", "").Replace("\t", "");
            
            calificaciones.Add(new Calificacion{
                Nombre = nombre,
                Puntuacion = puntuacion,
                Contenido = contenido,
                Imagen= pictureBox1.Image
            });

            tbNombre.Clear();
            nupValoracion.Value = 0;
            tbComentario.Clear();
            pictureBox1.Image = null;
        }

       
        private void btnExportar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Exportando las críticas";
            saveFileDialog1.Filter = "Fichero csv|*.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;

                try
                {
                    fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    string pathDir = Path.GetDirectoryName(saveFileDialog1.FileName);
                    int n = 0;
                    foreach (Calificacion c in calificaciones)
                    {
                        string pathImagen = $"imagen{ n++:00}.jpg";
                        sw.WriteLine($"{c.Nombre};{c.Contenido};{c.Puntuacion};{pathImagen}");
                        c.Imagen.Save(Path.Combine(pathDir, pathImagen));
                    }
                    sw.Close();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    if (fs != null)
                    {
                        if (sw != null) sw.Close();
                        fs.Close();
                        fs.Dispose();
                    }
                }
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
