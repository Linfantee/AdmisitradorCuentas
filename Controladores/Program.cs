using AdministradorCuentas.Servicios;

namespace AdministradorCuentas.Controladores
{
    /// <summary>
    /// Clase Principal de la operación
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// 250923 - lig
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion(); 
            mi.mostrarMensajeBienvenida();

            //Variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;
            //contener la opción del usuario
            int opcionSelecionada;

            //Desde la primera interacción debe cumplirse la condición
            while (!cerrarMenu)
            {
                opcionSelecionada = mi.mostrarMenuYSeleccion();

                switch (opcionSelecionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Se ejecuta caso 1");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Se ejecuta caso 2");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - Se ejecuta caso 3");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Se ejecuta caso 4");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - Se ejecuta caso 5");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opción seleccionada no coincide con ninguna");
                        break;
                }
            }
        }
    }
}             