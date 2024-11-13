
namespace AerolineaForms
{
    partial class Calculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMaletas = new System.Windows.Forms.TextBox();
            this.comboBoxTipoEquipaje = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMetodoPago = new System.Windows.Forms.ComboBox();
            this.labelImpuesto = new System.Windows.Forms.Label();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.labelCostoEquipaje = new System.Windows.Forms.Label();
            this.labelTotalPagar = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBoleto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 39);
            this.panel1.TabIndex = 38;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1000, 3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Selecciona el Tipo de Equipaje";
            // 
            // textBoxMaletas
            // 
            this.textBoxMaletas.Location = new System.Drawing.Point(693, 158);
            this.textBoxMaletas.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.textBoxMaletas.Name = "textBoxMaletas";
            this.textBoxMaletas.Size = new System.Drawing.Size(381, 20);
            this.textBoxMaletas.TabIndex = 46;
            this.textBoxMaletas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaletas_KeyPress);
            // 
            // comboBoxTipoEquipaje
            // 
            this.comboBoxTipoEquipaje.FormattingEnabled = true;
            this.comboBoxTipoEquipaje.Location = new System.Drawing.Point(693, 204);
            this.comboBoxTipoEquipaje.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.comboBoxTipoEquipaje.Name = "comboBoxTipoEquipaje";
            this.comboBoxTipoEquipaje.Size = new System.Drawing.Size(381, 21);
            this.comboBoxTipoEquipaje.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Seleciona El Metodo de pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ingresa Las Maletas Adicionales";
            // 
            // comboBoxMetodoPago
            // 
            this.comboBoxMetodoPago.FormattingEnabled = true;
            this.comboBoxMetodoPago.Location = new System.Drawing.Point(693, 247);
            this.comboBoxMetodoPago.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.comboBoxMetodoPago.Name = "comboBoxMetodoPago";
            this.comboBoxMetodoPago.Size = new System.Drawing.Size(381, 21);
            this.comboBoxMetodoPago.TabIndex = 42;
            // 
            // labelImpuesto
            // 
            this.labelImpuesto.AutoSize = true;
            this.labelImpuesto.Location = new System.Drawing.Point(421, 326);
            this.labelImpuesto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelImpuesto.Name = "labelImpuesto";
            this.labelImpuesto.Size = new System.Drawing.Size(10, 13);
            this.labelImpuesto.TabIndex = 52;
            this.labelImpuesto.Text = ".";
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Location = new System.Drawing.Point(634, 326);
            this.labelDescuento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(10, 13);
            this.labelDescuento.TabIndex = 51;
            this.labelDescuento.Text = ".";
            // 
            // labelCostoEquipaje
            // 
            this.labelCostoEquipaje.AutoSize = true;
            this.labelCostoEquipaje.Location = new System.Drawing.Point(421, 423);
            this.labelCostoEquipaje.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCostoEquipaje.Name = "labelCostoEquipaje";
            this.labelCostoEquipaje.Size = new System.Drawing.Size(10, 13);
            this.labelCostoEquipaje.TabIndex = 50;
            this.labelCostoEquipaje.Text = ".";
            // 
            // labelTotalPagar
            // 
            this.labelTotalPagar.AutoSize = true;
            this.labelTotalPagar.Location = new System.Drawing.Point(762, 486);
            this.labelTotalPagar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTotalPagar.Name = "labelTotalPagar";
            this.labelTotalPagar.Size = new System.Drawing.Size(10, 13);
            this.labelTotalPagar.TabIndex = 49;
            this.labelTotalPagar.Text = ".";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(627, 385);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(286, 40);
            this.btnCalcular.TabIndex = 48;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 330);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // btnBoleto
            // 
            this.btnBoleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoleto.Location = new System.Drawing.Point(959, 385);
            this.btnBoleto.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnBoleto.Name = "btnBoleto";
            this.btnBoleto.Size = new System.Drawing.Size(164, 40);
            this.btnBoleto.TabIndex = 54;
            this.btnBoleto.Text = "Solicitar Boleto";
            this.btnBoleto.UseVisualStyleBackColor = true;
            this.btnBoleto.Click += new System.EventHandler(this.btnBoleto_Click);
            // 
            // Calculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1193, 551);
            this.Controls.Add(this.btnBoleto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelImpuesto);
            this.Controls.Add(this.labelDescuento);
            this.Controls.Add(this.labelCostoEquipaje);
            this.Controls.Add(this.labelTotalPagar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMaletas);
            this.Controls.Add(this.comboBoxTipoEquipaje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMetodoPago);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculo";
            this.Text = "Calculo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMaletas;
        private System.Windows.Forms.ComboBox comboBoxTipoEquipaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMetodoPago;
        private System.Windows.Forms.Label labelImpuesto;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.Label labelCostoEquipaje;
        private System.Windows.Forms.Label labelTotalPagar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBoleto;
    }
}