namespace NumRotMetroInterfazDeUsuario
{
  partial class Tablero
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tablero));
      NumRotMetroLabel = new Label();
      ActualizarButton = new Button();
      SuspendLayout();
      // 
      // NumRotMetroLabel
      // 
      NumRotMetroLabel.AutoSize = true;
      NumRotMetroLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
      NumRotMetroLabel.ForeColor = Color.DodgerBlue;
      NumRotMetroLabel.Location = new Point(378, 21);
      NumRotMetroLabel.Name = "NumRotMetroLabel";
      NumRotMetroLabel.Size = new Size(179, 32);
      NumRotMetroLabel.TabIndex = 0;
      NumRotMetroLabel.Text = "NumRotMetro";
      // 
      // ActualizarButton
      // 
      ActualizarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
      ActualizarButton.ForeColor = Color.DodgerBlue;
      ActualizarButton.Location = new Point(421, 401);
      ActualizarButton.Name = "ActualizarButton";
      ActualizarButton.Size = new Size(99, 45);
      ActualizarButton.TabIndex = 1;
      ActualizarButton.Text = "Actualizar";
      ActualizarButton.UseVisualStyleBackColor = true;
      // 
      // Tablero
      // 
      AutoScaleDimensions = new SizeF(9F, 21F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      ClientSize = new Size(934, 502);
      Controls.Add(ActualizarButton);
      Controls.Add(NumRotMetroLabel);
      Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Margin = new Padding(4, 4, 4, 4);
      Name = "Tablero";
      Text = "Tablero";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label NumRotMetroLabel;
    private Button ActualizarButton;
  }
}