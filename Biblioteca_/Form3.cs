using Biblioteca_.prueba;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_
{
    public partial class Form3 : Form
    {
        private Controladores controladores;
        private Biblioteca biblioteca;
        public Form3(Biblioteca biblioteca)
        {
            this.controladores = new Controladores();
            this.biblioteca = biblioteca;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(codigoMaterial.Text);
                string titulo = tituloMaterial.Text;


                Material material = new Material(codigo, titulo, DateTime.Now, 0, 0);
                bool response = this.controladores.RegistrarMaterial(this.biblioteca, material);
                if (response)
                {
                    MessageBox.Show("Se ha registrado el material. ");
                }
                else
                {
                    MessageBox.Show("No se pueden registrar mas materiales. El catalogo esta lleno. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void registrarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(codigoMaterial.Text);
                int cedula = int.Parse(cedulaMaterial.Text);

                bool response = this.controladores.PrestamoDeMaterial(this.biblioteca, codigo, cedula);
                if (response)
                {
                    MessageBox.Show("Se ha registrado el prestamo. ");
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar el prestamo. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void tituloMaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void cedulaMaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrarDevolucion_Click(object sender, EventArgs e)
        {

            try
            {
                int codigo = int.Parse(codigoMaterial.Text);
                string titulo = tituloMaterial.Text;
                int cedula = int.Parse(cedulaMaterial.Text);



                Material material = new Material(codigo, titulo, DateTime.Now, 0, 0);
                bool response = this.controladores.DevolucionDeMaterial(this.biblioteca, codigo, cedula);
                if (response)
                {
                    MessageBox.Show("Se ha registrado la devolucion. ");
                }
                else
                {
                    MessageBox.Show("No se ha podido registrar la devolucion. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
