using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Academia.Data.Database;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        public UsuarioLogic UsuarioNegocio { get; set; } 

        public Usuarios( ) 
        {
            UsuarioNegocio = new UsuarioLogic();
        }
        public void Menu()
        {
            ConsoleKeyInfo rta;
            do
            {
                System.Console.Clear();
                System.Console.Write("MENU \n1- Listado General \n2- Consulta \n3- Agregar \n4- Modificar \n5- Eliminar \n6- Salir \n");
                do
                {
                    rta = System.Console.ReadKey();
                } while (!(rta.Key == ConsoleKey.D1 || rta.Key == ConsoleKey.D2 || rta.Key == ConsoleKey.D3 || rta.Key == ConsoleKey.D4 || rta.Key == ConsoleKey.D5 || rta.Key == ConsoleKey.D6));
                switch (rta.Key)
                {
                    case ConsoleKey.D1:
                        this.ListadoGeneral();
                        break;
                    case ConsoleKey.D2:
                        this.Consultar();
                        break;
                    case ConsoleKey.D3:
                        this.Agregar();
                        break;
                    case ConsoleKey.D4:
                        this.Modificar();
                        break;
                    case ConsoleKey.D5:
                        this.Eliminar();
                        break;
                }
                if (rta.Key != ConsoleKey.D6)
                {
                    System.Console.WriteLine("Presione una tecla para continuar.");
                    System.Console.ReadKey();
                }
            } while (rta.Key != ConsoleKey.D6);
        }

              public void MostrarDatos(Usuario usuario)
              {
                  System.Console.WriteLine("Usuario: " + usuario.Id); 
                  System.Console.WriteLine("\nNombre: "+ usuario.Persona.Nombre);
                  System.Console.WriteLine("\nApellido: " + usuario.Persona.Apellido);
                  System.Console.WriteLine("\nNombre de Usuario: " + usuario.NombreUsuario);
                  System.Console.WriteLine("\nClave: " + usuario.Clave);
                  System.Console.WriteLine("\nEmail: " + usuario.Persona.Email);
                  System.Console.WriteLine("\nHabilitado: " + usuario.Habilitado);
                  System.Console.WriteLine();
              }

        public void ListadoGeneral()
        {
            System.Console.Clear();
            EntidadesTP2 e = new EntidadesTP2();
            foreach (var usr in e.usuarios)
            {
                Console.WriteLine(usr.apellido);
            }
        }

        public void Consultar()
        {
            try
            {
                System.Console.Clear();
                System.Console.Write("Ingrese ID de la persona: ");
                int id = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(id));
            }
            catch (FormatException)
            {
                System.Console.WriteLine("El ID ingresado debe ser un número entero.");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public void Agregar()
        {
            try
            {
                System.Console.Clear();
                Usuario usuario = new Usuario();
                System.Console.Write("Ingrese Nombre: ");
                usuario.Persona.Nombre = System.Console.ReadLine();
                System.Console.Write("Ingrese Apellido: ");
                usuario.Persona.Apellido = System.Console.ReadLine();
                System.Console.Write("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = System.Console.ReadLine();
                System.Console.Write("Ingrese Clave: ");
                usuario.Clave = System.Console.ReadLine();
                System.Console.Write("Ingrese Email: ");
                usuario.Persona.Email = new MailAddress(System.Console.ReadLine());
                System.Console.Write("Ingrese Habilitación de Usuario (1-Si/Otro-NO): ");
                usuario.Habilitado = (System.Console.ReadLine() == "1");
                usuario.State = BusinessEntity.Estados.New;
                UsuarioNegocio.Save(usuario);
                System.Console.WriteLine("El ID del usuario creado es: {0}", usuario.Id);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            } 
        }

        public void Modificar()
        {
            try
            {
                System.Console.Clear();
                System.Console.Write("Ingrese ID de la persona: ");
                int id = int.Parse(System.Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(id);
                System.Console.Write("Ingrese Nombre: ");
                usuario.Persona.Nombre = System.Console.ReadLine();
                System.Console.Write("Ingrese Apellido: ");
                usuario.Persona.Apellido = System.Console.ReadLine();
                System.Console.Write("Ingrese Nombre de Usuario: ");
                usuario.NombreUsuario = System.Console.ReadLine();
                System.Console.Write("Ingrese Clave: ");
                usuario.Clave = System.Console.ReadLine();
                System.Console.Write("Ingrese Email: ");
                usuario.Persona.Email = new MailAddress(System.Console.ReadLine());
                System.Console.Write("Ingrese Habilitación de Usuario (1-Si/Otro-NO): ");
                usuario.Habilitado = (System.Console.ReadLine() == "1");
                usuario.State = BusinessEntity.Estados.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException)
            {
                System.Console.WriteLine("El ID ingresado debe ser un número entero.");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public void Eliminar()
        {
            try
            {
                System.Console.Clear();
                System.Console.Write("Ingrese ID de la persona: ");
                int id = int.Parse(System.Console.ReadLine());
                UsuarioNegocio.Delete(id);
            }
            catch (FormatException)
            {
                System.Console.WriteLine("El ID ingresado debe ser un número entero.");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }

    
}
