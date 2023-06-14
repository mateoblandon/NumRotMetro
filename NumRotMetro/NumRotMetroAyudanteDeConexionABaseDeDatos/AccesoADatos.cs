using Dapper; // Se agregó referencia Dapper para facilidad de ejecución de comeandos con bases de datos.
using Microsoft.Win32;
using MySqlConnector;
using NumRotMetroInterfaces;
using NumRotMetroModelos;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace NumRotMetroAyudanteDeConexionABaseDeDatos
{
  /// <summary>
  /// Clase que contiene métodos que ejecutan consultas y operaciones con los registros que arroja la base de datos.
  /// </summary>
  public class AccesoADatos : IOperacionesConDatos
  {
    /// <summary>
    /// Ejecuta query que selecciona todos los registros de la base datos.
    /// </summary>
    /// <returns>Devuelve lista de registros de la base de datos.</returns>
    public List<RegistroDeBaseDeDatos> ObtenerRegistros()
    {
      using (var conexion = new MySqlConnection(ConexionABaseDeDatos.ObtenerCadenaDeConexión("CadenaDeConexionLocal")))
      {
        const string query = "select * from facturaelectronicadetalle;";

        //conexion.Open();
        return conexion.Query<RegistroDeBaseDeDatos>(query).ToList();
      }
    }

    /// <summary>
    /// Obtiene los diferentes estados de documentos a partir de una lista de registros.
    /// </summary>
    /// <param name="registros">Lista con los registros que reprentan la información de documentos.</param>
    /// <returns></returns>
    public List<string> ObtenerDocumentoEstados(List<RegistroDeBaseDeDatos> registros)
    {
      return registros.Select(x => x.documentoEstadoDIAN).Distinct().ToList();
    }

    public Dictionary<string, int> AsignarDocumentoEstadosConSuCantidad(List<RegistroDeBaseDeDatos> registros, List<string> documentoEstados)
    {
      Dictionary<string, int> documentoEstadosDiccionario = new Dictionary<string, int>();
      foreach (string documentoEstado in documentoEstados)
      {
        int totalDocumentosEnEstadoX = registros.Where(x => x.documentoEstadoDIAN == documentoEstado).ToList().Count;
        documentoEstadosDiccionario.Add(documentoEstado, totalDocumentosEnEstadoX);
      }
      return documentoEstadosDiccionario;
    }
  }
}
