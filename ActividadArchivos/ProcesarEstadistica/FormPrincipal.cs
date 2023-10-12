using ProcesarEstadistica.Models;
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

namespace ProcesarEstadistica
{
    public partial class FormPrincipal : Form
    {
        List<Pelicula> peliculas = new List<Pelicula>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnImportarCriticas_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Fichero csv|*.csv";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileStream fs = null;
                StreamReader sr = null;

                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    string pathDir = Path.GetDirectoryName(path);

                    while (sr.EndOfStream == false)
                    {
                        string[] campos = sr.ReadLine().Split(';');

                        string nombre = campos[0].ToUpper().Trim();
                        string puntaje = campos[2].Trim();
                        string pathImagen = campos[3].Trim();

                        int idx = peliculas.BinarySearch(new Pelicula { Nombre = nombre });
                        if (idx > -1)
                        {
                            Pelicula buscada = peliculas[idx];
                            int valoracion = Convert.ToInt32(puntaje);
                            buscada.AcumValoraciones+=valoracion;
                            buscada.CantValoraciones++;
                        }
                        else
                        {
                            Image imagen = null;
                            if (string.IsNullOrEmpty(pathImagen) == false)
                            {
                                string pathNuevaImagen = Path.Combine(pathDir, pathImagen);
                                if (File.Exists(pathNuevaImagen)==true)
                                {
                                    imagen=Image.FromFile(pathNuevaImagen);
                                }
                            }
                            peliculas.Add(new Pelicula
                            {
                                Nombre = nombre,
                                AcumValoraciones = Convert.ToInt32(puntaje),
                                CantValoraciones=1,
                                Imagen =imagen
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                finally 
                {
                    if (fs != null)
                    {
                        if (sr != null)
                            sr.Close();

                        fs.Close();
                        fs.Dispose();
                    }
                }

                PintarGrilla();
            }
        }

        private void PintarGrilla()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Rows.Clear();
            foreach (Pelicula p in peliculas)
            {
                Bitmap bitmap = new Bitmap(p.Imagen, 100, 100);
                if (p.Imagen != null)
                {
                    bitmap = new Bitmap(p.Imagen, 100, 100);
                }

                dataGridView1.Rows.Add(new object[]{p.Nombre, p.PuntuacionPromedio.ToString("0.00"), bitmap });
            }
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
        }
    }
}
