namespace NumRotMetroInterazDeUsuario
{
  partial class tableroForm
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tableroForm));
      this.NumRotMetroLabel = new System.Windows.Forms.Label();
      this.ActualizarButton = new System.Windows.Forms.Button();
      this.numRotMetroPieChart = new LiveCharts.WinForms.PieChart();
      this.SuspendLayout();
      // 
      // NumRotMetroLabel
      // 
      this.NumRotMetroLabel.AutoSize = true;
      this.NumRotMetroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.NumRotMetroLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.NumRotMetroLabel.Location = new System.Drawing.Point(384, 20);
      this.NumRotMetroLabel.Name = "NumRotMetroLabel";
      this.NumRotMetroLabel.Size = new System.Drawing.Size(174, 29);
      this.NumRotMetroLabel.TabIndex = 0;
      this.NumRotMetroLabel.Text = "NumRotMetro";
      // 
      // ActualizarButton
      // 
      this.ActualizarButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.ActualizarButton.Location = new System.Drawing.Point(399, 425);
      this.ActualizarButton.Name = "ActualizarButton";
      this.ActualizarButton.Size = new System.Drawing.Size(144, 49);
      this.ActualizarButton.TabIndex = 1;
      this.ActualizarButton.Text = "Actualizar";
      this.ActualizarButton.UseVisualStyleBackColor = true;
      // 
      // numRotMetroPieChart
      // 
      this.numRotMetroPieChart.Location = new System.Drawing.Point(273, 70);
      this.numRotMetroPieChart.Name = "numRotMetroPieChart";
      this.numRotMetroPieChart.Size = new System.Drawing.Size(396, 295);
      this.numRotMetroPieChart.TabIndex = 2;
      this.numRotMetroPieChart.Text = "NumRotMetroPieChart";
      // 
      // tableroForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(942, 506);
      this.Controls.Add(this.numRotMetroPieChart);
      this.Controls.Add(this.ActualizarButton);
      this.Controls.Add(this.NumRotMetroLabel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "tableroForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tablero";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label NumRotMetroLabel;
    private System.Windows.Forms.Button ActualizarButton;
    private LiveCharts.WinForms.PieChart numRotMetroPieChart;
  }
}

