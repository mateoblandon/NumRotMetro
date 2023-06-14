using LiveCharts;
using LiveCharts.Wpf;
using NumRotMetroAyudanteDeConexionABaseDeDatos;
using NumRotMetroModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NumRotMetroInterazDeUsuario
{
  public partial class tableroForm : Form
  {
    List<RegistroDeBaseDeDatos> registros = new List<RegistroDeBaseDeDatos>();
    List<string> documentoEstados = new List<string>();
    Dictionary<string, int> documentoEstadosDiccionario = new Dictionary<string, int>();

    public tableroForm()
    {
      InitializeComponent();      
    }

    /// <summary>
    /// Inicializa los valores para la lista de registros obtenidos por base de datos, la lista de posibles estados de los documentos y diccionario cuya clave es el estado del documento y cuyo valor es el número total de documentos en el estado correspondiente a la clave. 
    /// </summary>
    private void EstablecerDatos()
    {
      AccesoADatos accesoADatos = new AccesoADatos();
      registros = accesoADatos.ObtenerRegistros();
      documentoEstados = registros.Select(x => x.documentoEstadoDIAN).Distinct().ToList();

      documentoEstadosDiccionario = new Dictionary<string, int>();
      foreach (string documentoEstado in documentoEstados)
      {
        int totalDocumentosEnEstadoX = registros.Where(x => x.documentoEstadoDIAN == documentoEstado).ToList().Count;
        documentoEstadosDiccionario.Add(documentoEstado, totalDocumentosEnEstadoX);
      }
    }

    /// <summary>
    /// Agrega series de datos al diagrama circular y establece las preferencias de la gráfica y el formulario de Windows.
    /// </summary>
    private void GraficarDatos()
    {
      SeriesCollection seriesDeDatos = new SeriesCollection();
      for (int i = 0; i < documentoEstados.Count; i++)
      {
        seriesDeDatos.Add(new PieSeries() { Title = documentoEstados[i], Values = new ChartValues<int> { documentoEstadosDiccionario[documentoEstados[i]] }, DataLabels = true });
      }

      numRotMetroPieChart.Series = seriesDeDatos;
      numRotMetroPieChart.InnerRadius = 80;
      numRotMetroPieChart.LegendLocation = LegendLocation.Bottom;
      fechaYHoralabel.Text = System.DateTime.Now.ToString();
      totalDeDocumentosLabel.Text = $"Documentos procesados{Environment.NewLine}hasta el momento:{Environment.NewLine}{registros.Count} ";
    }

    /// <summary>
    /// Actualiza el formulario de Windows.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ActualizarButton_Click(object sender, EventArgs e)
    {
      EstablecerDatos();
      GraficarDatos();
    }

    private void tableroForm_Load(object sender, EventArgs e)
    {
      EstablecerDatos();
      GraficarDatos();
    }
  }
}
