namespace WindowsFormsApp2
{
    partial class Ejemplo1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblapellidom = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblnacionalidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblfechanacimiento = new System.Windows.Forms.Label();
            this.chckbmostrardatos = new System.Windows.Forms.CheckBox();
            this.gropbotrosdatos = new System.Windows.Forms.GroupBox();
            this.listbpreferencia = new System.Windows.Forms.ListBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butonguardar = new System.Windows.Forms.Button();
            this.butonsalir = new System.Windows.Forms.Button();
            this.butonnuevo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gropbotrosdatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(68, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos generales";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.butonguardar);
            this.tabPage2.Controls.Add(this.butonsalir);
            this.tabPage2.Controls.Add(this.gropbotrosdatos);
            this.tabPage2.Controls.Add(this.butonnuevo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos opcionales";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.rbfemenino);
            this.groupBox1.Controls.Add(this.rbmasculino);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblnacionalidad);
            this.groupBox1.Controls.Add(this.lblsexo);
            this.groupBox1.Controls.Add(this.lblapellidom);
            this.groupBox1.Controls.Add(this.lblapellido);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Location = new System.Drawing.Point(41, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.chckbmostrardatos);
            this.groupBox2.Controls.Add(this.lblfechanacimiento);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(297, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del perfil";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblnombre.Location = new System.Drawing.Point(15, 29);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(67, 16);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblapellido.Location = new System.Drawing.Point(15, 55);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(88, 16);
            this.lblapellido.TabIndex = 1;
            this.lblapellido.Text = "Apellido P :";
            // 
            // lblapellidom
            // 
            this.lblapellidom.AutoSize = true;
            this.lblapellidom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblapellidom.Location = new System.Drawing.Point(15, 79);
            this.lblapellidom.Name = "lblapellidom";
            this.lblapellidom.Size = new System.Drawing.Size(90, 16);
            this.lblapellidom.TabIndex = 2;
            this.lblapellidom.Text = "Apellido M :";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(15, 104);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 3;
            this.lblsexo.Text = "Sexo";
            // 
            // lblnacionalidad
            // 
            this.lblnacionalidad.AutoSize = true;
            this.lblnacionalidad.Location = new System.Drawing.Point(15, 155);
            this.lblnacionalidad.Name = "lblnacionalidad";
            this.lblnacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lblnacionalidad.TabIndex = 4;
            this.lblnacionalidad.Text = "Nacionalidad";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(102, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(102, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Yellow;
            this.textBox3.Location = new System.Drawing.Point(102, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(64, 104);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(73, 17);
            this.rbmasculino.TabIndex = 8;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Location = new System.Drawing.Point(64, 128);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(71, 17);
            this.rbfemenino.TabIndex = 9;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Femenino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ecuatoriano",
            "Peruano",
            "Venezolano"});
            this.comboBox1.Location = new System.Drawing.Point(90, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Seleccione";
            // 
            // lblfechanacimiento
            // 
            this.lblfechanacimiento.AutoSize = true;
            this.lblfechanacimiento.Location = new System.Drawing.Point(37, 108);
            this.lblfechanacimiento.Name = "lblfechanacimiento";
            this.lblfechanacimiento.Size = new System.Drawing.Size(106, 13);
            this.lblfechanacimiento.TabIndex = 12;
            this.lblfechanacimiento.Text = "Fecha de nacimiento";
            // 
            // chckbmostrardatos
            // 
            this.chckbmostrardatos.AutoSize = true;
            this.chckbmostrardatos.Location = new System.Drawing.Point(40, 170);
            this.chckbmostrardatos.Name = "chckbmostrardatos";
            this.chckbmostrardatos.Size = new System.Drawing.Size(118, 17);
            this.chckbmostrardatos.TabIndex = 14;
            this.chckbmostrardatos.Text = "Mostrar estos datos";
            this.chckbmostrardatos.UseVisualStyleBackColor = true;
            // 
            // gropbotrosdatos
            // 
            this.gropbotrosdatos.BackColor = System.Drawing.Color.LightGray;
            this.gropbotrosdatos.Controls.Add(this.txtdescripcion);
            this.gropbotrosdatos.Controls.Add(this.D);
            this.gropbotrosdatos.Controls.Add(this.lbldescripcion);
            this.gropbotrosdatos.Controls.Add(this.listbpreferencia);
            this.gropbotrosdatos.Location = new System.Drawing.Point(76, 20);
            this.gropbotrosdatos.Name = "gropbotrosdatos";
            this.gropbotrosdatos.Size = new System.Drawing.Size(383, 234);
            this.gropbotrosdatos.TabIndex = 0;
            this.gropbotrosdatos.TabStop = false;
            this.gropbotrosdatos.Text = "Otros datos de usuario";
            // 
            // listbpreferencia
            // 
            this.listbpreferencia.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbpreferencia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listbpreferencia.FormattingEnabled = true;
            this.listbpreferencia.ItemHeight = 19;
            this.listbpreferencia.Items.AddRange(new object[] {
            "Bailar",
            "Estudiar",
            "Cantar",
            "Escuchar musica"});
            this.listbpreferencia.Location = new System.Drawing.Point(215, 61);
            this.listbpreferencia.Name = "listbpreferencia";
            this.listbpreferencia.Size = new System.Drawing.Size(120, 80);
            this.listbpreferencia.TabIndex = 0;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(42, 31);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 1;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(247, 31);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(66, 13);
            this.D.TabIndex = 2;
            this.D.Text = "Preferencias";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(30, 61);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdescripcion.Size = new System.Drawing.Size(115, 125);
            this.txtdescripcion.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.php;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(40, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 80);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // butonguardar
            // 
            this.butonguardar.Image = global::WindowsFormsApp2.Properties.Resources.guardar;
            this.butonguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonguardar.Location = new System.Drawing.Point(477, 95);
            this.butonguardar.Name = "butonguardar";
            this.butonguardar.Size = new System.Drawing.Size(75, 23);
            this.butonguardar.TabIndex = 5;
            this.butonguardar.Text = "Guardar";
            this.butonguardar.UseVisualStyleBackColor = true;
            // 
            // butonsalir
            // 
            this.butonsalir.Image = global::WindowsFormsApp2.Properties.Resources.salir;
            this.butonsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonsalir.Location = new System.Drawing.Point(477, 138);
            this.butonsalir.Name = "butonsalir";
            this.butonsalir.Size = new System.Drawing.Size(75, 23);
            this.butonsalir.TabIndex = 6;
            this.butonsalir.Text = "Salir";
            this.butonsalir.UseVisualStyleBackColor = true;
            // 
            // butonnuevo
            // 
            this.butonnuevo.Image = global::WindowsFormsApp2.Properties.Resources.agregar;
            this.butonnuevo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.butonnuevo.Location = new System.Drawing.Point(477, 51);
            this.butonnuevo.Name = "butonnuevo";
            this.butonnuevo.Size = new System.Drawing.Size(75, 23);
            this.butonnuevo.TabIndex = 4;
            this.butonnuevo.Text = "Nuevo";
            this.butonnuevo.UseVisualStyleBackColor = true;
            this.butonnuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejemplo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 381);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ejemplo1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ejemplo1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gropbotrosdatos.ResumeLayout(false);
            this.gropbotrosdatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.CheckBox chckbmostrardatos;
        private System.Windows.Forms.Label lblfechanacimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblnacionalidad;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblapellidom;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.GroupBox gropbotrosdatos;
        private System.Windows.Forms.Label D;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.ListBox listbpreferencia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button butonguardar;
        private System.Windows.Forms.Button butonsalir;
        private System.Windows.Forms.Button butonnuevo;
    }
}

