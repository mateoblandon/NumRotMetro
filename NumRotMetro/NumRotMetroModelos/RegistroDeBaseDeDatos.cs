using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumRotMetroModelos
{
  /// <summary>
  /// Las propiedades de este modelo no seguien la estructura Camel Case con el objetivo de que el nombre de las propiedades coincida con el nombre de las columnas de la base de datos.
  /// </summary>
  public class RegistroDeBaseDeDatos
  {
        /// <summary>
        /// Identificador de la empresa.
        /// </summary>
        public string empresaIdentificador { get; set; }
        /// <summary>
        /// Identificador del documento procesado.
        /// </summary>
        public string documentoNumero { get; set; }
        /// <summary>
        /// Nombre o razón social de la empresa.
        /// </summary>
        public string empresaNombre { get; set; }
        /// <summary>
        /// Fecha y hora del último procesamiento.
        /// </summary>
        public DateTime ultimoAcceso { get; set; }
    }
}
