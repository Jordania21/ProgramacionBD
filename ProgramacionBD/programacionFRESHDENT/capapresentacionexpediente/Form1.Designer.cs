namespace capapresentacionexpediente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.textBoxfechnac = new System.Windows.Forms.TextBox();
            this.textBoxcedula = new System.Windows.Forms.TextBox();
            this.textBoxcelular = new System.Windows.Forms.TextBox();
            this.textBoxmunicipio = new System.Windows.Forms.TextBox();
            this.textBoxdepartamento = new System.Windows.Forms.TextBox();
            this.textBoxapellido = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.labelfecnac = new System.Windows.Forms.Label();
            this.labelcedula = new System.Windows.Forms.Label();
            this.labelcelular = new System.Windows.Forms.Label();
            this.labelmunicipio = new System.Windows.Forms.Label();
            this.labelapellido = new System.Windows.Forms.Label();
            this.labeldepartamento = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelregpaciente = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonediar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.dataGridViewregpaciente = new System.Windows.Forms.DataGridView();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.textBoxbuscar = new System.Windows.Forms.TextBox();
            this.labelbucarregi = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewregpaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.Controls.Add(this.buttonguardar);
            this.tabPage1.Controls.Add(this.textBoxfechnac);
            this.tabPage1.Controls.Add(this.textBoxcedula);
            this.tabPage1.Controls.Add(this.textBoxcelular);
            this.tabPage1.Controls.Add(this.textBoxmunicipio);
            this.tabPage1.Controls.Add(this.textBoxdepartamento);
            this.tabPage1.Controls.Add(this.textBoxapellido);
            this.tabPage1.Controls.Add(this.textBoxnombre);
            this.tabPage1.Controls.Add(this.labelfecnac);
            this.tabPage1.Controls.Add(this.labelcedula);
            this.tabPage1.Controls.Add(this.labelcelular);
            this.tabPage1.Controls.Add(this.labelmunicipio);
            this.tabPage1.Controls.Add(this.labelapellido);
            this.tabPage1.Controls.Add(this.labeldepartamento);
            this.tabPage1.Controls.Add(this.labelnombre);
            this.tabPage1.Controls.Add(this.labelregpaciente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(737, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonguardar
            // 
            this.buttonguardar.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonguardar.Location = new System.Drawing.Point(310, 463);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(182, 47);
            this.buttonguardar.TabIndex = 63;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = true;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // textBoxfechnac
            // 
            this.textBoxfechnac.Location = new System.Drawing.Point(387, 405);
            this.textBoxfechnac.Multiline = true;
            this.textBoxfechnac.Name = "textBoxfechnac";
            this.textBoxfechnac.Size = new System.Drawing.Size(145, 30);
            this.textBoxfechnac.TabIndex = 62;
            // 
            // textBoxcedula
            // 
            this.textBoxcedula.Location = new System.Drawing.Point(281, 347);
            this.textBoxcedula.Multiline = true;
            this.textBoxcedula.Name = "textBoxcedula";
            this.textBoxcedula.Size = new System.Drawing.Size(143, 30);
            this.textBoxcedula.TabIndex = 61;
            // 
            // textBoxcelular
            // 
            this.textBoxcelular.Location = new System.Drawing.Point(290, 296);
            this.textBoxcelular.Multiline = true;
            this.textBoxcelular.Name = "textBoxcelular";
            this.textBoxcelular.Size = new System.Drawing.Size(149, 30);
            this.textBoxcelular.TabIndex = 60;
            // 
            // textBoxmunicipio
            // 
            this.textBoxmunicipio.Location = new System.Drawing.Point(310, 245);
            this.textBoxmunicipio.Multiline = true;
            this.textBoxmunicipio.Name = "textBoxmunicipio";
            this.textBoxmunicipio.Size = new System.Drawing.Size(182, 30);
            this.textBoxmunicipio.TabIndex = 59;
            // 
            // textBoxdepartamento
            // 
            this.textBoxdepartamento.Location = new System.Drawing.Point(335, 194);
            this.textBoxdepartamento.Multiline = true;
            this.textBoxdepartamento.Name = "textBoxdepartamento";
            this.textBoxdepartamento.Size = new System.Drawing.Size(187, 30);
            this.textBoxdepartamento.TabIndex = 58;
            // 
            // textBoxapellido
            // 
            this.textBoxapellido.Location = new System.Drawing.Point(290, 143);
            this.textBoxapellido.Multiline = true;
            this.textBoxapellido.Name = "textBoxapellido";
            this.textBoxapellido.Size = new System.Drawing.Size(232, 34);
            this.textBoxapellido.TabIndex = 57;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(290, 96);
            this.textBoxnombre.Multiline = true;
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(232, 30);
            this.textBoxnombre.TabIndex = 56;
            // 
            // labelfecnac
            // 
            this.labelfecnac.AutoSize = true;
            this.labelfecnac.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecnac.Location = new System.Drawing.Point(169, 405);
            this.labelfecnac.Name = "labelfecnac";
            this.labelfecnac.Size = new System.Drawing.Size(201, 30);
            this.labelfecnac.TabIndex = 55;
            this.labelfecnac.Text = "Fecha Nacimiento:";
            // 
            // labelcedula
            // 
            this.labelcedula.AutoSize = true;
            this.labelcedula.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcedula.Location = new System.Drawing.Point(173, 347);
            this.labelcedula.Name = "labelcedula";
            this.labelcedula.Size = new System.Drawing.Size(90, 30);
            this.labelcedula.TabIndex = 54;
            this.labelcedula.Text = "Cedula:";
            // 
            // labelcelular
            // 
            this.labelcelular.AutoSize = true;
            this.labelcelular.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcelular.Location = new System.Drawing.Point(169, 296);
            this.labelcelular.Name = "labelcelular";
            this.labelcelular.Size = new System.Drawing.Size(94, 30);
            this.labelcelular.TabIndex = 53;
            this.labelcelular.Text = "Celular:";
            // 
            // labelmunicipio
            // 
            this.labelmunicipio.AutoSize = true;
            this.labelmunicipio.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmunicipio.Location = new System.Drawing.Point(169, 245);
            this.labelmunicipio.Name = "labelmunicipio";
            this.labelmunicipio.Size = new System.Drawing.Size(123, 30);
            this.labelmunicipio.TabIndex = 52;
            this.labelmunicipio.Text = "Municipio:";
            // 
            // labelapellido
            // 
            this.labelapellido.AutoSize = true;
            this.labelapellido.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellido.Location = new System.Drawing.Point(169, 147);
            this.labelapellido.Name = "labelapellido";
            this.labelapellido.Size = new System.Drawing.Size(115, 30);
            this.labelapellido.TabIndex = 51;
            this.labelapellido.Text = "Apellidos:";
            // 
            // labeldepartamento
            // 
            this.labeldepartamento.AutoSize = true;
            this.labeldepartamento.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldepartamento.Location = new System.Drawing.Point(169, 194);
            this.labeldepartamento.Name = "labeldepartamento";
            this.labeldepartamento.Size = new System.Drawing.Size(167, 30);
            this.labeldepartamento.TabIndex = 50;
            this.labeldepartamento.Text = "Departamento:";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(169, 96);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(102, 30);
            this.labelnombre.TabIndex = 49;
            this.labelnombre.Text = "Nombre:";
            // 
            // labelregpaciente
            // 
            this.labelregpaciente.AutoSize = true;
            this.labelregpaciente.Font = new System.Drawing.Font("Sitka Small", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelregpaciente.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelregpaciente.Location = new System.Drawing.Point(252, 13);
            this.labelregpaciente.Name = "labelregpaciente";
            this.labelregpaciente.Size = new System.Drawing.Size(315, 48);
            this.labelregpaciente.TabIndex = 48;
            this.labelregpaciente.Text = "Registro Paciente";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.buttonediar);
            this.tabPage2.Controls.Add(this.buttoneliminar);
            this.tabPage2.Controls.Add(this.dataGridViewregpaciente);
            this.tabPage2.Controls.Add(this.buttonbuscar);
            this.tabPage2.Controls.Add(this.textBoxbuscar);
            this.tabPage2.Controls.Add(this.labelbucarregi);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(737, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalle";
            // 
            // buttonediar
            // 
            this.buttonediar.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonediar.Location = new System.Drawing.Point(499, 79);
            this.buttonediar.Name = "buttonediar";
            this.buttonediar.Size = new System.Drawing.Size(103, 41);
            this.buttonediar.TabIndex = 5;
            this.buttonediar.Text = "Editar";
            this.buttonediar.UseVisualStyleBackColor = true;
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Location = new System.Drawing.Point(608, 79);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(121, 41);
            this.buttoneliminar.TabIndex = 4;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewregpaciente
            // 
            this.dataGridViewregpaciente.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewregpaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewregpaciente.Location = new System.Drawing.Point(6, 186);
            this.dataGridViewregpaciente.Name = "dataGridViewregpaciente";
            this.dataGridViewregpaciente.Size = new System.Drawing.Size(723, 333);
            this.dataGridViewregpaciente.TabIndex = 3;
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.Font = new System.Drawing.Font("Sitka Small", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuscar.Location = new System.Drawing.Point(390, 79);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(103, 41);
            this.buttonbuscar.TabIndex = 2;
            this.buttonbuscar.Text = "Buscar";
            this.buttonbuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxbuscar
            // 
            this.textBoxbuscar.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxbuscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxbuscar.Location = new System.Drawing.Point(120, 83);
            this.textBoxbuscar.Multiline = true;
            this.textBoxbuscar.Name = "textBoxbuscar";
            this.textBoxbuscar.Size = new System.Drawing.Size(264, 41);
            this.textBoxbuscar.TabIndex = 1;
            this.textBoxbuscar.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // labelbucarregi
            // 
            this.labelbucarregi.AutoSize = true;
            this.labelbucarregi.Font = new System.Drawing.Font("Sitka Text", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbucarregi.Location = new System.Drawing.Point(8, 83);
            this.labelbucarregi.Name = "labelbucarregi";
            this.labelbucarregi.Size = new System.Drawing.Size(106, 39);
            this.labelbucarregi.TabIndex = 0;
            this.labelbucarregi.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewregpaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.TextBox textBoxfechnac;
        private System.Windows.Forms.TextBox textBoxcedula;
        private System.Windows.Forms.TextBox textBoxcelular;
        private System.Windows.Forms.TextBox textBoxmunicipio;
        private System.Windows.Forms.TextBox textBoxdepartamento;
        private System.Windows.Forms.TextBox textBoxapellido;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.Label labelfecnac;
        private System.Windows.Forms.Label labelcedula;
        private System.Windows.Forms.Label labelcelular;
        private System.Windows.Forms.Label labelmunicipio;
        private System.Windows.Forms.Label labelapellido;
        private System.Windows.Forms.Label labeldepartamento;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelregpaciente;
        private System.Windows.Forms.DataGridView dataGridViewregpaciente;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.TextBox textBoxbuscar;
        private System.Windows.Forms.Label labelbucarregi;
        private System.Windows.Forms.Button buttonediar;
        private System.Windows.Forms.Button buttoneliminar;
    }
}

