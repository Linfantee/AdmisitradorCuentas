﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorCuentas.Servicios
{
    /// <summary>
    /// Interfaz con la relación de métodos de función del menú
    /// 270923 - lig
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el menú y recoge la selección del usuario
        /// 270923 - lig
        /// Método que muestra el mensaje de bienvenida a la aplicación
        /// </summary>

        public void mostrarMensajeBienvenida();
        ///<summary>
        ///Método que muestra el mensaje
        ///270923 - lig
        /// </summary>
        /// <returns></returns>

        public int mostrarMenuYSeleccion();
    
    
    }


}
