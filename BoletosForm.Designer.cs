
namespace AerolineaForms
{
    partial class BoletosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoletosForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.dateTimePickerRetorno = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerSalida = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCiudadDestino = new System.Windows.Forms.ComboBox();
            this.comboBoxCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAerolinea = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoAvion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.IBIT = new System.Windows.Forms.Label();
            this.labelTarifaCalculada = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTotalapagar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 48);
            this.panel1.TabIndex = 113;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1057, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(1127, 239);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 41);
            this.btnLimpiar.TabIndex = 148;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(1127, 192);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 37);
            this.btnCancelar.TabIndex = 147;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(1127, 286);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 36);
            this.btnCalcular.TabIndex = 146;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Location = new System.Drawing.Point(1127, 145);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(121, 41);
            this.btnAñadir.TabIndex = 145;
            this.btnAñadir.Text = "AÑADIR";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // dateTimePickerRetorno
            // 
            this.dateTimePickerRetorno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerRetorno.CustomFormat = "yyyy-MM-dd  HH:mm";
            this.dateTimePickerRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRetorno.Location = new System.Drawing.Point(547, 232);
            this.dateTimePickerRetorno.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dateTimePickerRetorno.Name = "dateTimePickerRetorno";
            this.dateTimePickerRetorno.Size = new System.Drawing.Size(509, 20);
            this.dateTimePickerRetorno.TabIndex = 144;
            this.dateTimePickerRetorno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerRetorno_KeyPress);
            // 
            // dateTimePickerSalida
            // 
            this.dateTimePickerSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerSalida.CustomFormat = "yyyy-MM-dd  HH:mm";
            this.dateTimePickerSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSalida.Location = new System.Drawing.Point(547, 201);
            this.dateTimePickerSalida.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dateTimePickerSalida.Name = "dateTimePickerSalida";
            this.dateTimePickerSalida.Size = new System.Drawing.Size(509, 20);
            this.dateTimePickerSalida.TabIndex = 143;
            this.dateTimePickerSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerSalida_KeyPress);
            // 
            // comboBoxCiudadDestino
            // 
            this.comboBoxCiudadDestino.FormattingEnabled = true;
            this.comboBoxCiudadDestino.Location = new System.Drawing.Point(547, 166);
            this.comboBoxCiudadDestino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxCiudadDestino.Name = "comboBoxCiudadDestino";
            this.comboBoxCiudadDestino.Size = new System.Drawing.Size(509, 21);
            this.comboBoxCiudadDestino.TabIndex = 142;
            this.comboBoxCiudadDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCiudadDestino_KeyPress);
            // 
            // comboBoxCiudadOrigen
            // 
            this.comboBoxCiudadOrigen.FormattingEnabled = true;
            this.comboBoxCiudadOrigen.Location = new System.Drawing.Point(547, 124);
            this.comboBoxCiudadOrigen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxCiudadOrigen.Name = "comboBoxCiudadOrigen";
            this.comboBoxCiudadOrigen.Size = new System.Drawing.Size(509, 21);
            this.comboBoxCiudadOrigen.TabIndex = 141;
            this.comboBoxCiudadOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCiudadOrigen_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 335);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 140;
            this.label7.Text = "Ingresa la Ruta";
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Location = new System.Drawing.Point(547, 332);
            this.textBoxRuta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(509, 20);
            this.textBoxRuta.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 138;
            this.label5.Text = "Selecciona la Aerolinea";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 137;
            this.label4.Text = "Selecciona Tipo de avion";
            // 
            // comboBoxAerolinea
            // 
            this.comboBoxAerolinea.FormattingEnabled = true;
            this.comboBoxAerolinea.Location = new System.Drawing.Point(547, 295);
            this.comboBoxAerolinea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxAerolinea.Name = "comboBoxAerolinea";
            this.comboBoxAerolinea.Size = new System.Drawing.Size(509, 21);
            this.comboBoxAerolinea.TabIndex = 136;
            this.comboBoxAerolinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxAerolinea_KeyPress);
            // 
            // comboBoxTipoAvion
            // 
            this.comboBoxTipoAvion.FormattingEnabled = true;
            this.comboBoxTipoAvion.Location = new System.Drawing.Point(547, 263);
            this.comboBoxTipoAvion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxTipoAvion.Name = "comboBoxTipoAvion";
            this.comboBoxTipoAvion.Size = new System.Drawing.Size(509, 21);
            this.comboBoxTipoAvion.TabIndex = 135;
            this.comboBoxTipoAvion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTipoAvion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 134;
            this.label3.Text = "Fecha .Hora De Retorno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 133;
            this.label2.Text = "Ciudad de Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 132;
            this.label1.Text = "Fecha .Hora De Salida";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(373, 124);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 13);
            this.lblNombre.TabIndex = 131;
            this.lblNombre.Text = "Ciudad de Origen";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Yellow;
            this.btnBuscar.Location = new System.Drawing.Point(1129, 402);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 30);
            this.btnBuscar.TabIndex = 152;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(616, 407);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(482, 20);
            this.textBoxBuscar.TabIndex = 151;
            // 
            // IBIT
            // 
            this.IBIT.AutoSize = true;
            this.IBIT.Location = new System.Drawing.Point(335, 414);
            this.IBIT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IBIT.Name = "IBIT";
            this.IBIT.Size = new System.Drawing.Size(205, 13);
            this.IBIT.TabIndex = 150;
            this.IBIT.Text = "Buscar por Vuelos Disponibles Por Ciudad";
            // 
            // labelTarifaCalculada
            // 
            this.labelTarifaCalculada.AutoSize = true;
            this.labelTarifaCalculada.Font = new System.Drawing.Font("Broadway", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarifaCalculada.Location = new System.Drawing.Point(544, 462);
            this.labelTarifaCalculada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTarifaCalculada.Name = "labelTarifaCalculada";
            this.labelTarifaCalculada.Size = new System.Drawing.Size(13, 14);
            this.labelTarifaCalculada.TabIndex = 149;
            this.labelTarifaCalculada.Text = ".";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-25, 557);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1389, 159);
            this.dataGridView1.TabIndex = 153;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 255);
            this.pictureBox1.TabIndex = 154;
            this.pictureBox1.TabStop = false;
            // 
            // labelTotalapagar
            // 
            this.labelTotalapagar.AutoSize = true;
            this.labelTotalapagar.Font = new System.Drawing.Font("Broadway", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalapagar.Location = new System.Drawing.Point(102, 462);
            this.labelTotalapagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalapagar.Name = "labelTotalapagar";
            this.labelTotalapagar.Size = new System.Drawing.Size(13, 14);
            this.labelTotalapagar.TabIndex = 155;
            this.labelTotalapagar.Text = ".";
            // 
            // BoletosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1285, 788);
            this.Controls.Add(this.labelTotalapagar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.IBIT);
            this.Controls.Add(this.labelTarifaCalculada);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dateTimePickerRetorno);
            this.Controls.Add(this.dateTimePickerSalida);
            this.Controls.Add(this.comboBoxCiudadDestino);
            this.Controls.Add(this.comboBoxCiudadOrigen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAerolinea);
            this.Controls.Add(this.comboBoxTipoAvion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoletosForm";
            this.Text = "BoletosForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DateTimePicker dateTimePickerRetorno;
        private System.Windows.Forms.DateTimePicker dateTimePickerSalida;
        private System.Windows.Forms.ComboBox comboBoxCiudadDestino;
        private System.Windows.Forms.ComboBox comboBoxCiudadOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAerolinea;
        private System.Windows.Forms.ComboBox comboBoxTipoAvion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label IBIT;
        private System.Windows.Forms.Label labelTarifaCalculada;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTotalapagar;
    }
}