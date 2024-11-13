
namespace AerolineaForms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroPasaporte = new System.Windows.Forms.TextBox();
            this.txtPreferenciaAsiento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lBIPreferenciaAsiento = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNumeroPasaporte = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRcalculo = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 54);
            this.panel1.TabIndex = 96;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(825, 11);
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
            this.pictureBox1.Location = new System.Drawing.Point(343, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 163);
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(267, 273);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(371, 20);
            this.dtpFechaNacimiento.TabIndex = 105;
            this.dtpFechaNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaNacimiento_KeyPress);
            // 
            // txtNumeroPasaporte
            // 
            this.txtNumeroPasaporte.Location = new System.Drawing.Point(267, 300);
            this.txtNumeroPasaporte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeroPasaporte.Name = "txtNumeroPasaporte";
            this.txtNumeroPasaporte.Size = new System.Drawing.Size(371, 20);
            this.txtNumeroPasaporte.TabIndex = 104;
            this.txtNumeroPasaporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroPasaporte_KeyPress);
            // 
            // txtPreferenciaAsiento
            // 
            this.txtPreferenciaAsiento.Location = new System.Drawing.Point(267, 327);
            this.txtPreferenciaAsiento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPreferenciaAsiento.Name = "txtPreferenciaAsiento";
            this.txtPreferenciaAsiento.Size = new System.Drawing.Size(371, 20);
            this.txtPreferenciaAsiento.TabIndex = 103;
            this.txtPreferenciaAsiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreferenciaAsiento_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(267, 246);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(371, 20);
            this.txtNombre.TabIndex = 102;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lBIPreferenciaAsiento
            // 
            this.lBIPreferenciaAsiento.AutoSize = true;
            this.lBIPreferenciaAsiento.Location = new System.Drawing.Point(68, 334);
            this.lBIPreferenciaAsiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBIPreferenciaAsiento.Name = "lBIPreferenciaAsiento";
            this.lBIPreferenciaAsiento.Size = new System.Drawing.Size(96, 13);
            this.lBIPreferenciaAsiento.TabIndex = 101;
            this.lBIPreferenciaAsiento.Text = "PreferenciaAsiento";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(68, 280);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblFechaNacimiento.TabIndex = 99;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblNumeroPasaporte
            // 
            this.lblNumeroPasaporte.AutoSize = true;
            this.lblNumeroPasaporte.Location = new System.Drawing.Point(68, 307);
            this.lblNumeroPasaporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroPasaporte.Name = "lblNumeroPasaporte";
            this.lblNumeroPasaporte.Size = new System.Drawing.Size(92, 13);
            this.lblNumeroPasaporte.TabIndex = 100;
            this.lblNumeroPasaporte.Text = "NumeroPasaporte";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(68, 249);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 98;
            this.lblNombre.Text = "Nombre";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(38, 416);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(666, 250);
            this.dataGridViewUser.TabIndex = 106;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(758, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 589);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(244, 358);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 52);
            this.btnLimpiar.TabIndex = 108;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRcalculo
            // 
            this.btnRcalculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRcalculo.Location = new System.Drawing.Point(409, 358);
            this.btnRcalculo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRcalculo.Name = "btnRcalculo";
            this.btnRcalculo.Size = new System.Drawing.Size(122, 52);
            this.btnRcalculo.TabIndex = 109;
            this.btnRcalculo.Text = "Calculo";
            this.btnRcalculo.UseVisualStyleBackColor = true;
            this.btnRcalculo.Click += new System.EventHandler(this.btnRcalculo_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Location = new System.Drawing.Point(565, 358);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(122, 52);
            this.btnAñadir.TabIndex = 110;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1019, 690);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnRcalculo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtNumeroPasaporte);
            this.Controls.Add(this.txtPreferenciaAsiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lBIPreferenciaAsiento);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblNumeroPasaporte);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtNumeroPasaporte;
        private System.Windows.Forms.TextBox txtPreferenciaAsiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lBIPreferenciaAsiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNumeroPasaporte;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRcalculo;
        private System.Windows.Forms.Button btnAñadir;
    }
}