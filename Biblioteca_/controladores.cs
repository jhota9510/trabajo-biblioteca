using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_
{
    using System;
    using System.Drawing.Text;
    using System.IO;
    using System.Linq.Expressions;
    using System.Windows.Forms;

    namespace prueba
    {
        public class Controladores
        {
            public Controladores()
            {
            }


            public bool RegistrarMaterial(Biblioteca biblioteca, Material material)
            {
                if (biblioteca == null)
                {
                    throw new Exception("La biblioteca no ha sido inicializada. ");
                }

                if (BuscarPorCodigo(biblioteca, material.Codigo) != null)
                {
                    throw new Exception("Existe un libro con ese codigo. ");
                }

                biblioteca.Catalogo.Add(material);

                escribirArchivoCatalogo(biblioteca);

                return true;
            }


            public Material BuscarPorCodigo(Biblioteca biblioteca, int codigo)
            {
                foreach (Material material in biblioteca.Catalogo)
                {
                    if (material != null && material.Codigo == codigo)
                    {
                        return material;
                    }
                }
                return null;
            }

            private bool rolValido(string rol)
            {
                string[] rolesValidos = { "estudiante", "profesor", "administrativo" };
                return rolesValidos.Contains(rol.ToLower());
            }

            public bool RegistrarUsuario(Biblioteca biblioteca, Usuario usuario)
            {
                if (!rolValido(usuario.Rol))
                {
                    throw new Exception("Rol no valido. Los roles permitidos son: Estudiante, Profesor o Administrativo. ");
                }

                if (BuscarUsuarioPorCedula(biblioteca, usuario.Cedula) != null)
                {
                    throw new Exception("Ya existe un usuario activo con este numero de cedula. ");
                }

                biblioteca.Usuarios.Add(usuario);

                return true;
                
            }
            

            public Usuario BuscarUsuarioPorCedula(Biblioteca biblioteca, int cedula)
            {
                foreach (Usuario user in biblioteca.Usuarios)
                {
                    if (user != null && user.Cedula == cedula)
                    {
                        return user;
                    }
                }
                return null;
            }


            public bool EliminarUsuario(Biblioteca biblioteca, int cedula)
            {
                Usuario user = BuscarUsuarioPorCedula(biblioteca, cedula);
                if (user == null)
                {
                    throw new Exception("No existe un usuario con esa cedula. ");
                }

                if (user.PrestamosActuales > 0)
                {
                    throw new Exception("El usuario tiene materiales prestados actualmente, no puede ser eliminado hasta que retorne el material. ");
                }

                return biblioteca.Usuarios.Remove(user);
            }


            public bool PrestamoDeMaterial(Biblioteca biblioteca, int codigo, int cedula)
            {
                try
                {
                    Material material = BuscarPorCodigo(biblioteca, codigo);
                    Usuario usuario = BuscarUsuarioPorCedula(biblioteca, cedula);

                    if (material == null)
                    {
                        throw new Exception("No se ha podido encontrar el material. ");
                    }

                    if (usuario == null)

                    {
                        throw new Exception("No se ha podido encontrar el usuario. ");
                    }

                    if (material.CantidadActual <= 0)
                    {
                        throw new Exception("No hay suficientes unidades disponibles del material. ");
                    }

                    int prestamosMaximos;
                    switch (usuario.Rol.ToLower())
                    {
                        case "estudiante":
                            prestamosMaximos = 5;
                            break;
                        case "profesor":
                            prestamosMaximos = 3;
                            break;
                        case "administrativo":
                            prestamosMaximos = 1;
                            break;
                        default:
                            throw new Exception("Rol no valido. ");
                    }

                    if (usuario.PrestamosActuales >= prestamosMaximos)
                    {
                        throw new Exception("El usuario no puede realizar mas prestamos. Limite maximo alcanzado. ");
                    }

                    material.CantidadActual--;
                    usuario.AgregarPrestamo(material);

                    biblioteca.Historial.Add(new Movimiento("Prestamo", DateTime.Now, material, usuario));
                    biblioteca.ContadorMovimientos++;
                    return true;
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }

            public bool DevolucionDeMaterial(Biblioteca biblioteca, int codigo, int cedula)
            {
                try
                {
                    Material material = BuscarPorCodigo(biblioteca, codigo);
                    Usuario usuario = BuscarUsuarioPorCedula(biblioteca, cedula);

                    if (material == null)
                    {
                        throw new Exception("No se ha podido encontrar el material. ");
                    }

                    if (usuario == null)

                    {
                        throw new Exception("No se ha podido encontrar el usuario. ");
                    }

                    if(usuario.PrestamosActuales <=0 || !usuario.TienePrestamo(material))
                    {
                        throw new Exception("El usuario no tiene prestamos en el momento. No se puede realizar la devolucion. ");
                    }

                    material.CantidadActual++;
                    usuario.RemoverPrestamo(material);

                    biblioteca.Historial.Add(new Movimiento("Devolucion", DateTime.Now, material, usuario));
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false;
                }
            }

            

            public void HistorialBiblioteca(Biblioteca biblioteca)
            {
                foreach(Movimiento movimiento in biblioteca.Historial)
                {
                    Console.WriteLine($"Tipo:{movimiento.TipoDeMovimiento}, Fecha:{movimiento.FechaMovimiento}, Material: {movimiento.Material.Titulo}, Usuario: {movimiento.Usuario.Nombre}" );
                }
            }

            public bool IncrementarCantidadMaterial(Biblioteca biblioteca, int codigo, int cantidadAIncrementar)
            {
                if (biblioteca == null)
                {
                    throw new Exception("La biblioteca no se ha iniciado. ");
                }

                Material material = BuscarPorCodigo(biblioteca, codigo);
                if (material == null)
                {
                    throw new Exception("No se ha encontrado el material. ");
                }

                material.CantidadActual += cantidadAIncrementar;

                escribirArchivoCatalogo(biblioteca);

                return true;
            }

            private void escribirArchivoCatalogo(Biblioteca biblioteca)
            {
                try
                {
                    StreamWriter sw = new StreamWriter("../../Catalogo.txt");
                    sw.WriteLine("CODIGO TITULO CANTIDAD");
                    foreach (Material material in biblioteca.Catalogo)
                    {
                        if (material != null)
                        {
                            sw.WriteLine(material.Export());
                        }
                    }
                    sw.Close();
                }

                catch (Exception e)
                {
                    MessageBox.Show("Exception: " + e.Message);
                }
                finally
                {
                    MessageBox.Show("Executing finally block. ");
                }
            }

            public void importarCatalogo(Biblioteca biblioteca)
            {
                String line;
                try
                {
                    using (StreamReader sr = new StreamReader("../../Catalogo.txt"))
                    {
                        sr.ReadLine();

                        while((line = sr.ReadLine()) != null)
                        {
                            try
                            {
                                string[] textLine = line.Split(',');
                                if(textLine.Length == 3)
                                {
                                    int codigo = int.Parse(textLine[0].Trim());
                                    string titulo = textLine[1].Trim();
                                    int cantidadActual = int.Parse(textLine[2].Trim());

                                    Material materialExistente = BuscarPorCodigo(biblioteca, codigo);
                                    if(materialExistente != null)
                                    {
                                        materialExistente.CantidadActual = cantidadActual;
                                    }
                                    else
                                    {
                                        Material material = new Material(codigo, titulo, DateTime.Now, cantidadActual, cantidadActual);
                                        biblioteca.Catalogo.Add(material);
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Error procesando la linea: " + line + " - " + e.Message);
                                continue;
                            }
                        }
                    }                    
                }

                catch (Exception e)
                {
                    MessageBox.Show("Error al leer el archivo: "+e.Message);
                } 
            }
        }
    }
}
