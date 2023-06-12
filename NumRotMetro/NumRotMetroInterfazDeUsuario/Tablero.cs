using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;


namespace NumRotMetroInterfazDeUsuario
{
  public partial class tableroForm : Form
  {
    public tableroForm()
    {
      InitializeComponent();
    }

    private void tableroForm_Load(object sender, EventArgs e)
    {
      numrotmetroPieChart.LegendLocation = LegendLocation.Bottom;
    }
  }
}
