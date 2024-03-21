namespace W_UE_Analog
{
    partial class AnalogWriter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lightninginput = new System.Windows.Forms.NumericUpDown();
            this.submitbutton = new System.Windows.Forms.Button();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lightninginput)).BeginInit();
            this.SuspendLayout();
            // 
            // lightninginput
            // 
            this.lightninginput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lightninginput.Location = new System.Drawing.Point(21, 32);
            this.lightninginput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.lightninginput.Name = "lightninginput";
            this.lightninginput.Size = new System.Drawing.Size(120, 22);
            this.lightninginput.TabIndex = 0;
            this.lightninginput.ValueChanged += new System.EventHandler(this.lightninginput_ValueChanged);
            // 
            // submitbutton
            // 
            this.submitbutton.BackColor = System.Drawing.Color.LightYellow;
            this.submitbutton.Location = new System.Drawing.Point(21, 79);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(147, 39);
            this.submitbutton.TabIndex = 1;
            this.submitbutton.Text = "Helligkeit festlegen";
            this.submitbutton.UseVisualStyleBackColor = false;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.PortName = "COM3";
            // 
            // AnalogWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.lightninginput);
            this.Name = "AnalogWriter";
            this.Text = "AnalogWriter";
            ((System.ComponentModel.ISupportInitialize)(this.lightninginput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown lightninginput;
        private System.Windows.Forms.Button submitbutton;
        private System.IO.Ports.SerialPort serialPortArduino;
    }
}

