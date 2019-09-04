namespace WindowsFormsApp4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCapital = new System.Windows.Forms.Label();
            this.labelRazon = new System.Windows.Forms.Label();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.labelTotalInteres = new System.Windows.Forms.Label();
            this.labelMontofinal = new System.Windows.Forms.Label();
            this.textCapital = new System.Windows.Forms.TextBox();
            this.textRazon = new System.Windows.Forms.TextBox();
            this.textTiempo = new System.Windows.Forms.TextBox();
            this.textTotalInteres = new System.Windows.Forms.TextBox();
            this.textMontoFinal = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSalir);
            this.groupBox1.Controls.Add(this.buttonNuevo);
            this.groupBox1.Controls.Add(this.buttonCalcular);
            this.groupBox1.Controls.Add(this.textTiempo);
            this.groupBox1.Controls.Add(this.textRazon);
            this.groupBox1.Controls.Add(this.textCapital);
            this.groupBox1.Controls.Add(this.labelTiempo);
            this.groupBox1.Controls.Add(this.labelRazon);
            this.groupBox1.Controls.Add(this.labelCapital);
            this.groupBox1.Location = new System.Drawing.Point(234, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textMontoFinal);
            this.groupBox2.Controls.Add(this.textTotalInteres);
            this.groupBox2.Controls.Add(this.labelMontofinal);
            this.groupBox2.Controls.Add(this.labelTotalInteres);
            this.groupBox2.Location = new System.Drawing.Point(234, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // labelCapital
            // 
            this.labelCapital.AutoSize = true;
            this.labelCapital.Location = new System.Drawing.Point(6, 27);
            this.labelCapital.Name = "labelCapital";
            this.labelCapital.Size = new System.Drawing.Size(39, 13);
            this.labelCapital.TabIndex = 0;
            this.labelCapital.Text = "Capital";
            // 
            // labelRazon
            // 
            this.labelRazon.AutoSize = true;
            this.labelRazon.Location = new System.Drawing.Point(6, 52);
            this.labelRazon.Name = "labelRazon";
            this.labelRazon.Size = new System.Drawing.Size(38, 13);
            this.labelRazon.TabIndex = 1;
            this.labelRazon.Text = "Razon";
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Location = new System.Drawing.Point(6, 75);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(42, 13);
            this.labelTiempo.TabIndex = 2;
            this.labelTiempo.Text = "Tiempo";
            // 
            // labelTotalInteres
            // 
            this.labelTotalInteres.AutoSize = true;
            this.labelTotalInteres.Location = new System.Drawing.Point(17, 33);
            this.labelTotalInteres.Name = "labelTotalInteres";
            this.labelTotalInteres.Size = new System.Drawing.Size(65, 13);
            this.labelTotalInteres.TabIndex = 3;
            this.labelTotalInteres.Text = "Total interes";
            // 
            // labelMontofinal
            // 
            this.labelMontofinal.AutoSize = true;
            this.labelMontofinal.Location = new System.Drawing.Point(17, 67);
            this.labelMontofinal.Name = "labelMontofinal";
            this.labelMontofinal.Size = new System.Drawing.Size(59, 13);
            this.labelMontofinal.TabIndex = 4;
            this.labelMontofinal.Text = "Monto final";
            // 
            // textCapital
            // 
            this.textCapital.Location = new System.Drawing.Point(47, 24);
            this.textCapital.Name = "textCapital";
            this.textCapital.Size = new System.Drawing.Size(100, 20);
            this.textCapital.TabIndex = 3;
            // 
            // textRazon
            // 
            this.textRazon.Location = new System.Drawing.Point(47, 49);
            this.textRazon.Name = "textRazon";
            this.textRazon.Size = new System.Drawing.Size(100, 20);
            this.textRazon.TabIndex = 4;
            // 
            // textTiempo
            // 
            this.textTiempo.Location = new System.Drawing.Point(47, 75);
            this.textTiempo.Name = "textTiempo";
            this.textTiempo.Size = new System.Drawing.Size(100, 20);
            this.textTiempo.TabIndex = 5;
            // 
            // textTotalInteres
            // 
            this.textTotalInteres.Location = new System.Drawing.Point(112, 30);
            this.textTotalInteres.Name = "textTotalInteres";
            this.textTotalInteres.Size = new System.Drawing.Size(100, 20);
            this.textTotalInteres.TabIndex = 6;
            // 
            // textMontoFinal
            // 
            this.textMontoFinal.Location = new System.Drawing.Point(112, 60);
            this.textMontoFinal.Name = "textMontoFinal";
            this.textMontoFinal.Size = new System.Drawing.Size(100, 20);
            this.textMontoFinal.TabIndex = 7;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(286, 17);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 6;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(286, 46);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 7;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(286, 77);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 8;
            this.buttonSalir.Text = "Sali";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textTiempo;
        private System.Windows.Forms.TextBox textRazon;
        private System.Windows.Forms.TextBox textCapital;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelRazon;
        private System.Windows.Forms.Label labelCapital;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textMontoFinal;
        private System.Windows.Forms.TextBox textTotalInteres;
        private System.Windows.Forms.Label labelMontofinal;
        private System.Windows.Forms.Label labelTotalInteres;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Timer timer1;
    }
}

