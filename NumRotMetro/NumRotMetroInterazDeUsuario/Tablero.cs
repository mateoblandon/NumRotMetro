using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumRotMetroInterazDeUsuario
{
  public partial class tableroForm : Form
  {
    public tableroForm()
    {
      InitializeComponent();
      EstablecerDatos();
    }
    /// <summary>
    /// Agrega series de datos al diagram circular.
    /// </summary>
    private void EstablecerDatos()
    {
      SeriesCollection seriesDeDatos = new SeriesCollection();
      seriesDeDatos.Add(new PieSeries() { Title = "Serie 1", Values = new ChartValues<int> { 1200 }, DataLabels = true });
      seriesDeDatos.Add(new PieSeries() { Title = "Serie 2", Values = new ChartValues<int> { 750 }, DataLabels = true });
      numRotMetroPieChart.Series = seriesDeDatos;
      numRotMetroPieChart.LegendLocation = LegendLocation.Bottom;
    }
  }
}
