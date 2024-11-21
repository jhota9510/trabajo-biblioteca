using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_
{
    public class Material
    {
        private int codigo;
        private string titulo;
        private DateTime fechaDeRegistro;
        private int cantidadeDeRegistro;
        private int cantidadActual;

        public Material(int codigo, string titulo, DateTime fechaDeRegistro, int cantidadeDeRegistro, int cantidadActual)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.fechaDeRegistro = fechaDeRegistro;
            this.cantidadeDeRegistro = cantidadeDeRegistro;
            this.cantidadActual = cantidadActual;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime FechaDeRegistro { get => fechaDeRegistro; set => fechaDeRegistro = value; }
        public int CantidadeDeRegistro { get => cantidadeDeRegistro; set => cantidadeDeRegistro = value; }
        public int CantidadActual { get => cantidadActual; set => cantidadActual = value; }

        public String ToString()
        {
            return "Codigo: " + codigo +
                   "\nTitulo: " + titulo +
                   "\nCantidad actual" + cantidadActual;
        }

        public String Export()
        {
            return $"{this.codigo},{ this.titulo},{ this.cantidadActual}";
        }
    }

    public class Usuario
    {
        private string nombre;
        private int cedula;
        private string rol;
        private int prestamosActuales;
        private List<Material> materialesPrestados;

        public Usuario(string nombre, int cedula, string rol, int prestamosActuales)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.rol = rol;
            this.prestamosActuales = prestamosActuales;
            this.materialesPrestados = new List<Material>();
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Rol { get => rol; set => rol = value; }
        public int PrestamosActuales { get => prestamosActuales; set => prestamosActuales = value; }

        public void AgregarPrestamo(Material material)
        {
            materialesPrestados.Add(material);
            prestamosActuales++;
        }

        public void RemoverPrestamo(Material material)
        {
            if(materialesPrestados.Remove(material))
            {
                prestamosActuales--;
            }
        }

        public bool TienePrestamo(Material material)
        {
            return materialesPrestados.Contains(material);
        }
    }

    public class Movimiento
    {
        private string tipoDeMovimiento;
        private DateTime fechaMovimiento;
        private Material material;
        private Usuario usuario;

        public Movimiento(string tipoDeMovimiento, DateTime fechaMovimiento, Material material, Usuario usuario)
        {
            this.tipoDeMovimiento = tipoDeMovimiento;
            this.fechaMovimiento = fechaMovimiento;
            this.material = material;
            this.usuario = usuario;
        }

        public string TipoDeMovimiento { get => tipoDeMovimiento; set => tipoDeMovimiento = value; }
        public DateTime FechaMovimiento { get => fechaMovimiento; set => fechaMovimiento = value; }
        public Material Material { get => material; set => material = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
    }

    public class Biblioteca
    {
        private List <Material> catalogo;
        private List <Usuario> usuarios;
        private List <Movimiento> historial;
        private int contadorMovimientos;

        public Biblioteca()
        {
            this.Catalogo = new List<Material>();
            this.Usuarios = new List<Usuario>();
            this.Historial = new List<Movimiento>();
            this.ContadorMovimientos = 0;
        }

        public List<Material> Catalogo { get => catalogo; set => catalogo = value; }
        public List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        public List<Movimiento> Historial { get => historial; set => historial = value; }
        public int ContadorMovimientos { get => contadorMovimientos; set => contadorMovimientos = value; }
    }
}
