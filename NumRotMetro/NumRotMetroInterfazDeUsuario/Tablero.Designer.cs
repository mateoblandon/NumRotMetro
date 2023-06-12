namespace NumRotMetroInterfazDeUsuario
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
      this.numrotmetroLabel = new System.Windows.Forms.Label();
      this.actualizarButton = new System.Windows.Forms.Button();
      this.numrotmetroPieChart = new LiveCharts.WinForms.PieChart();
      this.SuspendLayout();
      // 
      // numrotmetroLabel
      // 
      this.numrotmetroLabel.AutoSize = true;
      this.numrotmetroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numrotmetroLabel.ForeColor = System.Drawing.Color.DodgerBlue;
      this.numrotmetroLabel.Location = new System.Drawing.Point(365, 9);
      this.numrotmetroLabel.Name = "numrotmetroLabel";
      this.numrotmetroLabel.Size = new System.Drawing.Size(174, 29);
      this.numrotmetroLabel.TabIndex = 0;
      this.numrotmetroLabel.Text = "NumRotMetro";
      // 
      // actualizarButton
      // 
      this.actualizarButton.ForeColor = System.Drawing.Color.DodgerBlue;
      this.actualizarButton.Location = new System.Drawing.Point(402, 422);
      this.actualizarButton.Name = "actualizarButton";
      this.actualizarButton.Size = new System.Drawing.Size(101, 48);
      this.actualizarButton.TabIndex = 1;
      this.actualizarButton.Text = "Actualizar";
      this.actualizarButton.UseVisualStyleBackColor = true;
      // 
      // numrotmetroPieChart
      // 
      this.numrotmetroPieChart.Location = new System.Drawing.Point(256, 79);
      this.numrotmetroPieChart.Name = "numrotmetroPieChart";
      this.numrotmetroPieChart.Size = new System.Drawing.Size(393, 290);
      this.numrotmetroPieChart.TabIndex = 2;
      this.numrotmetroPieChart.Text = "numrotmetroPieChart";
      // 
      // tableroForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(905, 496);
      this.Controls.Add(this.numrotmetroPieChart);
      this.Controls.Add(this.actualizarButton);
      this.Controls.Add(this.numrotmetroLabel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "tableroForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tablero";
      this.Load += new System.EventHandler(this.tableroForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label numrotmetroLabel;
    private System.Windows.Forms.Button actualizarButton;
    private LiveCharts.WinForms.PieChart numrotmetroPieChart;
  }
}

