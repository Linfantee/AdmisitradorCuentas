using AdministradorCuentas.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdministradorCuentas.Controladores
{
    /// <summary>
    /// Clase que implementa las acciones del menú
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {


        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Bienvenido de nuevo a tu cuenta";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("#################");
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Visualizar el dinero del usuario");
            Console.WriteLine("2. Visualizar las cuentas");
            Console.WriteLine("3. Ver las tarjetas");
            Console.WriteLine("4. Transferir dinero");
            Console.WriteLine("5. Historial de operaciones");
            Console.WriteLine("###################");
            Console.WriteLine("Seleccione una opción: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;

        }

       
        
    }
    }
