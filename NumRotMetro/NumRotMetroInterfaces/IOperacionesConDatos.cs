using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumRotMetroInterfaces
{
  /// <summary>
  /// Interface con los métodos requeridos en la interfaz de usurio para el funcionamiento de la solución NumRotMetro.
  /// </summary>
  public interface IOperacionesConDatos
  {
    /// <summary>
    /// Método para ejecutar consulta a base de datos y obetener registros.
    /// </summary>
    void ObtenerRegistros();
  }
}
