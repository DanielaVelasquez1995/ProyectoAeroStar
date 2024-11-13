
namespace AerolineaForms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lBIPreferenciaAsiento = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNumeroPasaporte = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNumeroPasaporte = new System.Windows.Forms.TextBox();
            this.txtPreferenciaAsiento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.IBIT = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 54);
            this.panel1.TabIndex = 95;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(945, 12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(360, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 159);
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // lBIPreferenciaAsiento
            // 
            this.lBIPreferenciaAsiento.AutoSize = true;
            this.lBIPreferenciaAsiento.Location = new System.Drawing.Point(89, 328);
            this.lBIPreferenciaAsiento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lBIPreferenciaAsiento.Name = "lBIPreferenciaAsiento";
            this.lBIPreferenciaAsiento.Size = new System.Drawing.Size(96, 13);
            this.lBIPreferenciaAsiento.TabIndex = 104;
            this.lBIPreferenciaAsiento.Text = "PreferenciaAsiento";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(89, 268);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblFechaNacimiento.TabIndex = 103;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblNumeroPasaporte
            // 
            this.lblNumeroPasaporte.AutoSize = true;
            this.lblNumeroPasaporte.Location = new System.Drawing.Point(89, 297);
            this.lblNumeroPasaporte.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumeroPasaporte.Name = "lblNumeroPasaporte";
            this.lblNumeroPasaporte.Size = new System.Drawing.Size(92, 13);
            this.lblNumeroPasaporte.TabIndex = 102;
            this.lblNumeroPasaporte.Text = "NumeroPasaporte";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(346, 264);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(509, 20);
            this.dtpFechaNacimiento.TabIndex = 101;
            this.dtpFechaNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaNacimiento_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(89, 239);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 100;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNumeroPasaporte
            // 
            this.txtNumeroPasaporte.Location = new System.Drawing.Point(346, 297);
            this.txtNumeroPasaporte.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtNumeroPasaporte.Name = "txtNumeroPasaporte";
            this.txtNumeroPasaporte.Size = new System.Drawing.Size(509, 20);
            this.txtNumeroPasaporte.TabIndex = 99;
            this.txtNumeroPasaporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPasaporte_KeyPress);
            // 
            // txtPreferenciaAsiento
            // 
            this.txtPreferenciaAsiento.Location = new System.Drawing.Point(346, 330);
            this.txtPreferenciaAsiento.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtPreferenciaAsiento.Name = "txtPreferenciaAsiento";
            this.txtPreferenciaAsiento.Size = new System.Drawing.Size(509, 20);
            this.txtPreferenciaAsiento.TabIndex = 98;
            this.txtPreferenciaAsiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreferenciaAsiento_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(346, 232);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(509, 20);
            this.txtNombre.TabIndex = 97;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // IBIT
            // 
            this.IBIT.AutoSize = true;
            this.IBIT.Location = new System.Drawing.Point(161, 379);
            this.IBIT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IBIT.Name = "IBIT";
            this.IBIT.Size = new System.Drawing.Size(276, 13);
            this.IBIT.TabIndex = 110;
            this.IBIT.Text = "Buscar por nombre asi hace las funciones de los botones";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(728, 372);
            this.txtId.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(135, 20);
            this.txtId.TabIndex = 109;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Location = new System.Drawing.Point(456, 434);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(175, 55);
            this.btnConsultar.TabIndex = 108;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(642, 434);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 55);
            this.btnEliminar.TabIndex = 107;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(271, 434);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(175, 55);
            this.btnModificar.TabIndex = 106;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Location = new System.Drawing.Point(92, 434);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(168, 55);
            this.btnAñadir.TabIndex = 105;
            this.btnAñadir.Text = "AÑADIR";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(41, 510);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.RowHeadersWidth = 51;
            this.dataGridViewUsuarios.RowTemplate.Height = 24;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(881, 253);
            this.dataGridViewUsuarios.TabIndex = 111;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(932, 101);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 649);
            this.pictureBox2.TabIndex = 112;
            this.pictureBox2.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1199, 788);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.IBIT);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lBIPreferenciaAsiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNumeroPasaporte);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNumeroPasaporte);
            this.Controls.Add(this.txtPreferenciaAsiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lBIPreferenciaAsiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNumeroPasaporte;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNumeroPasaporte;
        private System.Windows.Forms.TextBox txtPreferenciaAsiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label IBIT;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}