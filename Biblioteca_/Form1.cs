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
    public partial class Form1 : Form
    {
        private Biblioteca biblioteca;
        private Controladores controladores;
        
        public Form1()
        {
            InitializeComponent();
            this.biblioteca = new Biblioteca();
            MessageBox.Show("Se ha creado la biblioteca. ");
            this.controladores = new Controladores();
            this.controladores.importarCatalogo(this.biblioteca);


        }
        private void abrirFormhoja(object formhoja)
        {
            if (this.panelMenu.Controls.Count > 0)
                this.panelMenu.Controls.RemoveAt(0);
            Form fh = formhoja as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(fh);
            this.panelMenu.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FormUsuarios = new Form2(this.biblioteca);
            abrirFormhoja(new Form2(this.biblioteca));
        }

        private void material_Click(object sender, EventArgs e)
        {
            Form FormMaterial = new Form3(this.biblioteca);
            abrirFormhoja(new Form3(this.biblioteca));
        }

        private void biblio_Click(object sender, EventArgs e)
        {
            Form FormBiblioteca = new Form4(this.biblioteca);
            abrirFormhoja(new Form4(this.biblioteca));
        }
    }
}
