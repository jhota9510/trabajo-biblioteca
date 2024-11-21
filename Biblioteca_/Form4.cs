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
    public partial class Form4 : Form
    {
        private Controladores controladores;
        private Biblioteca biblioteca;
        public Form4(Biblioteca biblioteca)
        {
            this.controladores = new Controladores();
            this.biblioteca = biblioteca;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void incrementarCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(codigoCantidadAIncrementar.Text);
                int cantidadAIncrementar = int.Parse(cantidadIncrementarMaterial.Text);

                bool response = this.controladores.IncrementarCantidadMaterial(this.biblioteca, codigo, cantidadAIncrementar);
                if(response)
                {
                    MessageBox.Show("Se ha incrementado la cantidad del material. " + codigo);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void historialBiblioteca_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.biblioteca.Historial.Count==0)
                {
                    MessageBox.Show("No hay movimientos registrados en el historial. ");
                    return;
                }

                StringBuilder historial = new StringBuilder();

                foreach (Movimiento movimiento in this.biblioteca.Historial)
                {
                    historial.AppendLine($"Tipo: {movimiento.TipoDeMovimiento}, Fecha: {movimiento.FechaMovimiento}, Material: {movimiento.Material.Titulo}, Usuario:{movimiento.Usuario.Nombre}");
                }

                MessageBox.Show(historial.ToString(), "Historial de la Biblioteca. ");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
