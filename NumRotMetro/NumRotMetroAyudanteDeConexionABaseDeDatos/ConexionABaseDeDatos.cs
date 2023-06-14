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
    /// <param name="nombreDeCadenaDeConexion">Nombre de la cadena de conexión establecida en el archivo App.Config. </param>
    /// <returns>String con cadena de conexión establecida en el archivo App.Config.</returns>
    public static string ObtenerCadenaDeConexión(string nombreDeCadenaDeConexion)
    {
      return ConfigurationManager.ConnectionStrings[nombreDeCadenaDeConexion].ConnectionString;
    }
  }
}
