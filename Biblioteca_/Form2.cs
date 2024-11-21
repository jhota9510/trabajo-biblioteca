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
    public partial class Form2 : Form
    {
        private Controladores controladores;
        private Biblioteca biblioteca;
        public Form2(Biblioteca biblioteca)
        {
            InitializeComponent();
            this.controladores = new Controladores();
            this.biblioteca = biblioteca;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void registrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int cedula = int.Parse(cedulaUsuario.Text);
                string nombre = nombreUsuario.Text;
                string rol = rolUsuario.Text;
                int prestamosActuales = 0;


                Usuario user = new Usuario(nombre, cedula, rol, prestamosActuales);
                bool response = this.controladores.RegistrarUsuario(this.biblioteca, user);
                if (response)
                {
                    MessageBox.Show("Se ha registrado el usuario. ");
                }
                else
                {
                    MessageBox.Show("No se pueden registrar mas usuarios. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int cedula = int.Parse(cedulaUsuario.Text);
                string nombre = nombreUsuario.Text;
                string rol = rolUsuario.Text;



                Usuario user = new Usuario(nombre, cedula, rol, 0);
                bool response = this.controladores.EliminarUsuario(this.biblioteca, cedula);
                if (response)
                {
                    MessageBox.Show("Se ha elimando el usuario. ");
                }
                else
                {
                    MessageBox.Show("No existen mas usuarios para eliminar. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
