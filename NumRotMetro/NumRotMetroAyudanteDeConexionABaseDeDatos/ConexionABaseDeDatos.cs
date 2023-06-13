using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //Para usar los métodos de este namespace fue necesario agregar la referencia System.Configuration.

namespace NumRotMetroAyudanteDeConexionABaseDeDatos
{
  /// <summary>
  /// Clase con métodos que facilitan la conexión a una base de datos. 
  /// </summary>
  public static class ConexionABaseDeDatos
  {
    /// <summary>
    /// Obtiene de cadena de conexión establecida en el archivo App.Config de la intefaz de usuario.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static string CadenaDeConexión(string name)
    {
      return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
  }
}
