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
      this.fechaYHoralabel = new System.Windows.Forms.Label();
      this.totalDeDocumentosLabel = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
      this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
      // 
      // numRotMetroPieChart
      // 
      this.numRotMetroPieChart.Location = new System.Drawing.Point(273, 70);
      this.numRotMetroPieChart.Name = "numRotMetroPieChart";
      this.numRotMetroPieChart.Size = new System.Drawing.Size(396, 295);
      this.numRotMetroPieChart.TabIndex = 2;
      this.numRotMetroPieChart.Text = "NumRotMetroPieChart";
      // 
      // fechaYHoralabel
      // 
      this.fechaYHoralabel.AutoSize = true;
      this.fechaYHoralabel.Location = new System.Drawing.Point(708, 29);
      this.fechaYHoralabel.Name = "fechaYHoralabel";
      this.fechaYHoralabel.Size = new System.Drawing.Size(101, 20);
      this.fechaYHoralabel.TabIndex = 3;
      this.fechaYHoralabel.Text = "Fehca y hora";
      // 
      // totalDeDocumentosLabel
      // 
      this.totalDeDocumentosLabel.AutoSize = true;
      this.totalDeDocumentosLabel.Location = new System.Drawing.Point(712, 70);
      this.totalDeDocumentosLabel.Name = "totalDeDocumentosLabel";
      this.totalDeDocumentosLabel.Size = new System.Drawing.Size(158, 20);
      this.totalDeDocumentosLabel.TabIndex = 4;
      this.totalDeDocumentosLabel.Text = "Total de docuemntos";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::NumRotMetroInterazDeUsuario.Properties.Resources.Logovsdc2;
      this.pictureBox1.Location = new System.Drawing.Point(24, 20);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(138, 29);
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // tableroForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(942, 506);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.totalDeDocumentosLabel);
      this.Controls.Add(this.fechaYHoralabel);
      this.Controls.Add(this.numRotMetroPieChart);
      this.Controls.Add(this.ActualizarButton);
      this.Controls.Add(this.NumRotMetroLabel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "tableroForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tablero";
      this.Load += new System.EventHandler(this.tableroForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label NumRotMetroLabel;
    private System.Windows.Forms.Button ActualizarButton;
    private LiveCharts.WinForms.PieChart numRotMetroPieChart;
    private System.Windows.Forms.Label fechaYHoralabel;
    private System.Windows.Forms.Label totalDeDocumentosLabel;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

