using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AerolineaForms
{
   

    public partial class Calculo : Form
    {


        //cadena de conexion de mysql con el nombre de la base de datos, el usuario y contraseña

        private string connectionString = "server=localhost;user=root;password=1234;database=aerolinea";


        //Construccior de la clase Calculo.Inicializa la interfaz y la conexion a la base de datos
        public Calculo()
        {
            //Inicializa la conexion con la base de datos
            InitializeComponent();
            /*inicializar los métodos de pago*/
            comboBoxMetodoPago.Items.Add("Tarjeta de crédito");
            comboBoxMetodoPago.Items.Add("Tarjeta de débito");
            comboBoxMetodoPago.Items.Add("PayPal");
            comboBoxMetodoPago.Items.Add("Transferencia");

            // Inicializar el tipo de equipaje
            comboBoxTipoEquipaje.Items.Add("Equipaje de mano");
            comboBoxTipoEquipaje.Items.Add("Equipaje de bodega");

            // Eventos para calcular automáticamente
            comboBoxTipoEquipaje.SelectedIndexChanged += ComboBoxTipoEquipaje_SelectedIndexChanged;
            textBoxMaletas.TextChanged += TextBoxMaletas_TextChanged;
        }

        private void TextBoxMaletas_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxMaletas.Text, out int maletasAdicionales))
            {
                calcularCostos(maletasAdicionales);
            }
        }

        private void ComboBoxTipoEquipaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxMaletas.Text, out int maletasAdicionales))
            {
                calcularCostos(maletasAdicionales);
            }
        }

        //boton calcular del formulario
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxMaletas.Text))
                {
                    MessageBox.Show("El campo de maletas está vacío. Por favor, ingresa una cantidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxMaletas.Text, out int maletasAdicionales) || maletasAdicionales < 0)
                {
                    MessageBox.Show("Por favor, ingresa un número válido de maletas.");
                    return;
                }

                calcularCostos(maletasAdicionales);

                // Aquí llamamos a la función que inserta los datos en la base de datos
                if (InsertarDatosEnBaseDeDatos(maletasAdicionales))
                {
                    MessageBox.Show("Los datos se han ingresado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un problema al guardar los datos en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            // Validar selección en comboBoxMetodoPago
            if (comboBoxMetodoPago.SelectedItem == null || comboBoxMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un método de pago.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar selección en comboBoxTipoEquipaje
            if (comboBoxTipoEquipaje.SelectedItem == null || comboBoxTipoEquipaje.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un tipo de equipaje.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxMaletas.Text))
            {
                MessageBox.Show("El campo de maletas está vacío. Por favor, ingresa una cantidad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        // Ejemplo de función para insertar datos en la base de datos
        private bool InsertarDatosEnBaseDeDatos(int maletasAdicionales)
        {
            try
            {
                // Aquí iría la lógica para insertar los datos en la base de datos.
                // Ejemplo: Ejecutar una consulta SQL de inserción

                // Si la inserción es exitosa
                return true;
            }
            catch
            {
                // Si ocurre algún error
                MessageBox.Show("Porfavor Ingrese todos los Datos correctamente. ","Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void calcularCostos(int maletasAdicionales)
        {
            decimal costoEquipaje = 0;
            decimal impuesto = 0;

            if (comboBoxTipoEquipaje.SelectedItem != null)
            {
                string tipoEquipaje = comboBoxTipoEquipaje.SelectedItem.ToString();

                if (tipoEquipaje == "Equipaje de mano")
                {
                    costoEquipaje = 10m; // Costo fijo por maleta de mano
                    impuesto = 5m;       // Impuesto fijo por maleta de mano
                }
                else if (tipoEquipaje == "Equipaje de bodega")
                {
                    costoEquipaje = 20m; // Costo fijo por maleta de bodega
                    impuesto = 10m;      // Impuesto fijo por maleta de bodega
                }

                decimal totalCostoEquipaje = costoEquipaje * maletasAdicionales;
                decimal totalImpuesto = impuesto * maletasAdicionales;
                decimal totalPagar = totalCostoEquipaje + totalImpuesto;

                // Mostrar en etiquetas
                labelCostoEquipaje.Text = $"Costo de Equipaje: {totalCostoEquipaje:C}";
                labelImpuesto.Text = $"Impuesto: {totalImpuesto:C}";
                labelTotalPagar.Text = $"Total a Pagar: {totalPagar:C}";

                // Guardar reserva en base de datos
                guardarReserva(maletasAdicionales, totalCostoEquipaje, totalImpuesto, totalPagar, comboBoxMetodoPago.SelectedItem?.ToString(), tipoEquipaje);
            }
        }
      

        private void btnBoleto_Click(object sender, EventArgs e)
        {

            BoletosForm boleto = new BoletosForm();
            this.Hide();
            boleto.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Mensaje a reflejar antes de cerrar el programa 
            var resultado = MessageBox.Show("¿Deseas cerrar el programa?", "Confirmacion de accion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            //Resultado segun opcion 
            if (resultado == DialogResult.Yes)
            {
                //Cierre de programa
                Application.Exit();
            }
        }
        //metodo de guardar reserva de datos del usuario
        private void guardarReserva( int maletasAdicionales, decimal costoEquipaje, decimal impuesto,decimal totalPagar, string metodoPago, string tipoEquipaje)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO reservas (maletas_adicionales, costo_equipaje, impuesto, total_pagar, metodo_pago, tipo_equipaje) " +
                               "VALUES (@maletasAdicionales, @costoEquipaje, @impuesto, @totalPagar, @metodoPago, @tipoEquipaje)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maletasAdicionales", maletasAdicionales);
                    command.Parameters.AddWithValue("@costoEquipaje", costoEquipaje);
                    command.Parameters.AddWithValue("@impuesto", impuesto);
                    command.Parameters.AddWithValue("@totalPagar", totalPagar);
                    command.Parameters.AddWithValue("@metodoPago", metodoPago ?? string.Empty);
                    command.Parameters.AddWithValue("@tipoEquipaje", tipoEquipaje);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void textBoxMaletas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y la tecla de retroceso para corregir
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Por favor, ingresa solo números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true; // Evita que el carácter no válido se ingrese
            }


        }
    }
}
