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
    /// <summary>
    /// Autores: Alvarado Méndez Oscar Eduardo  - AM22043
    ///          Martínez Hernández Wendy Beatriz - MH22052
    ///          Orellana Velasquez Daniela Estefany - OV22002
    ///          Ramirez Vasquez Nancy Esmeralda - RV24003
    /// Grupo De Trabajo:  Grupo #3
    /// Hora:1:00 p.m
    /// Fecha:26-10-2024
    /// Descripcion:Este sistema de boletos aéreos gestiona y controla todo el flujo de información relacionado con la reserva y compra de boletos para vuelos. 
    /// Incluye datos completos de aerolíneas, vuelos, rutas, horarios, tarifas, aviones, tripulación y pasajeros. 
    /// Los usuarios pueden realizar reservaciones ingresando detalles del vuelo, como origen, destino y fechas, para recibir una lista de opciones disponibles 
    /// que contiene información detallada sobre cada vuelo, permitiendo así un proceso de compra rápido y organizado.
    /// <param comboBoxCiudadOrigen.Text>Es la cuidad origen de la persoana</param>
    /// <param comboBoxCiudadDestino.Text>Es la cuidad destino de la persoana</param>
    /// <param dateTimePickerSalida.Value>Es la fecha y hora de salida</param>
    /// <param dateTimePickerRetorno.Value>Es la fecha y hora de retorno</param>
    public partial class BoletosForm : Form
    {


       
        private MySqlConnection connection;
        private MySqlConnection conexion; // se declara la conexión a la base de datos MySQL


        //Construccior de la clase BoletosForm.Inicializa la interfaz y la conexion a la base de datos
        public BoletosForm()
        {
            InitializeComponent();

            //Cadena de conexion de mysql con el nombre de la base , el usuario y contraseña
            string connectionString = "Server=localhost;Database=aerolinea;User ID=root;Password=1234;";
            connection = new MySqlConnection(connectionString);
            InicializarConexion();  // llama al método que incia la conexión con la base de datos
            
            LoadComboBoxes(); //Carga los datos de los ComboBox

            CargarDatos(); //metodo para cargar los datos 
        }
        //los datos de los comboBox de aerolinea y tipo de avion 
        private void LoadComboBoxes()
        {
            // Agregar aerolíneas al ComboBox
            comboBoxAerolinea.Items.Add("SkyFly Airlines");
            comboBoxAerolinea.Items.Add("AeroExpress");
            comboBoxAerolinea.Items.Add("Global Wings");

            // Agregar tipos de avión al ComboBox
            comboBoxTipoAvion.Items.Add("Airbus A320");
            comboBoxTipoAvion.Items.Add("Boeing 737");
            comboBoxTipoAvion.Items.Add("Embraer E195");

            // Poblar ComboBox de Ciudades (origen y destino)
            comboBoxCiudadOrigen.Items.AddRange(new string[] { "San Salvador", "Ciudad de Guatemala", "Toronto", "Sao Paulo", "Ciudad de Mexico", "San Jose", "Belmopan" });
            comboBoxCiudadDestino.Items.AddRange(new string[] { "Buenos Aires", "Nueva York", "Tokio", "Sidney", "Berlin", "Londres", "Amsterdam", "Dubai", "Korea" });
        }
        private void InicializarConexion()
        {
            // la conexión con los parámetros necesarios para conectarse a la BD MySql
            string cadenaConexion = "Server=localhost;Database= aerolinea ;User ID=root;Password=1234;SslMode=none;";
            conexion = new MySqlConnection(cadenaConexion);  // se crea una instancia de MySqlConnection con la cadena de conexión
        }

        //Carga los datos de vuelos desde la base de datos al DataGridView 
        private void CargarDatos()
        {
            //Inicio Del Try - Catch
            try
            {
                // verifica si la conexión está cerrada antes de abrirla
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();  // abre la conexión si está cerrada
                }

                // consulta SQL para los registros de la tabla `resgusuario`
                string consulta = "SELECT * FROM vuelos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion); // crea un adaptador de datos con la consulta y la conexión
                DataTable dt = new DataTable();  // crea una tabla en memoria para almacenar los datos
                adapter.Fill(dt);  // llena la tabla con los datos obtenidos de la consulta
                dataGridView1.DataSource = dt;  // asigna la tabla como fuente de datos del DataGridView para mostrar los registros
            }
            catch (Exception ex)
            {
                // muestra un mensaje en caso de que ocurra un error al cargar los datos
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                // cierra la conexión si está abierta, independientemente de si hubo error o no
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            //Fin Del Try - Catch
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            // Primero, verifica si todos los campos están completos
            if (!ValidarCampos())
            {
                // Si algún campo está vacío, muestra un mensaje y termina el método aquí
                MessageBox.Show("Por favor, completa todos los campos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si pasa la validación, procede con los datos de entrada
            string aerolinea = comboBoxAerolinea.Text;
            string ciudadOrigen = comboBoxCiudadOrigen.Text;
            string ciudadDestino = comboBoxCiudadDestino.Text;
            string tipoAvion = comboBoxTipoAvion.Text;
            string ruta = textBoxRuta.Text;
            DateTime fechaHoraSalida = dateTimePickerSalida.Value;
            DateTime fechaHoraRetorno = dateTimePickerRetorno.Value;

            try
            {
                // Abre la conexión
                conexion.Open();

                // Inserta los datos en la base de datos
                string query = "INSERT INTO vuelos (aerolinea, ciudad_origen, ciudad_destino, tipo_avion, ruta, fecha_hora_salida, fecha_hora_retorno) VALUES (@aerolinea, @ciudad_origen, @ciudad_destino, @tipo_avion, @ruta, @fecha_hora_salida, @fecha_hora_retorno)";
                MySqlCommand command = new MySqlCommand(query, conexion);

                // Agrega los valores de los parámetros a la consulta
                command.Parameters.AddWithValue("@aerolinea", aerolinea);
                command.Parameters.AddWithValue("@ciudad_origen", ciudadOrigen);
                command.Parameters.AddWithValue("@ciudad_destino", ciudadDestino);
                command.Parameters.AddWithValue("@tipo_avion", tipoAvion);
                command.Parameters.AddWithValue("@ruta", ruta);
                command.Parameters.AddWithValue("@fecha_hora_salida", fechaHoraSalida);
                command.Parameters.AddWithValue("@fecha_hora_retorno", fechaHoraRetorno);

                // Ejecuta la consulta y muestra un mensaje de éxito
                command.ExecuteNonQuery();
                MessageBox.Show("Vuelo añadido con éxito.");

                // Recarga los datos para reflejar el nuevo registro
                CargarDatos();
            }
            catch (Exception ex)
            {
                // Muestra un mensaje en caso de error al intentar insertar el registro
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión
                conexion.Close();
            }

        }

        //Boton de eliminar que permite cancelar resrvacion del formulario 
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            //ID del vuelo seleccionado
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            int vueloId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["id"].Value);
            //Consulta SQL para eliminar el vuelo por su ID 
            string query = $"DELETE FROM vuelos WHERE id = {vueloId}";
            //Inico del Try- Catch
            try
            {
                //abre la conexion
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                // mensaje de exito de cancelacion de vuelo
                MessageBox.Show("Vuelo cancelacion con éxito.");
                //metodo para cargar datos
                CargarDatos();
            }
            finally
            {
                //cierra la conexion
                connection.Close();
            }
            //Fin del Try-Catch
        }
        //Boton de limpiar del formulario de los textboxs
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxCiudadOrigen.SelectedIndex = -1;
            comboBoxCiudadDestino.SelectedIndex = -1;
            textBoxRuta.Clear();
            labelTarifaCalculada.Text = "Tarifa Calculada: ";
            comboBoxAerolinea.SelectedIndex = -1;
            comboBoxTipoAvion.SelectedIndex = -1;
            dateTimePickerSalida.Value = DateTime.Now;
            dateTimePickerRetorno.Value = DateTime.Now;
        }
        //Boton calcular para asignar la tarifa del boleto 
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Las ciudades y opciones seleccionadas
            string ciudadOrigen = comboBoxCiudadOrigen.SelectedItem?.ToString();
            string ciudadDestino = comboBoxCiudadDestino.SelectedItem?.ToString();
            string tipoAvion = comboBoxTipoAvion.SelectedItem?.ToString();
            string aerolinea = comboBoxAerolinea.SelectedItem?.ToString();

            // Verificamos que todas las opciones estén seleccionadas
            if (string.IsNullOrEmpty(ciudadOrigen) || string.IsNullOrEmpty(ciudadDestino) ||
                string.IsNullOrEmpty(tipoAvion) || string.IsNullOrEmpty(aerolinea))
            {
                labelTarifaCalculada.Text = "Por favor, seleccione todas las opciones (origen, destino, tipo de avión y aerolínea).";
                return;
            }

            // Definir tarifa base
            double tarifa = 0;
            double duracionVuelo = 0;// Duración del vuelo en horas

            //Ciudad de Origen"San Salvador", "Ciudad de Guatemala", "Toronto", "Sao Paulo", "Ciudad de Mexico", "San Jose", "Belmopan" 
            //Ciudad de Destino   "Buenos Aires", "Nueva York", "Tokio", "Sidney", "Berlin", "Londres", "Amsterdam", "Dubai", "Korea" 


            // El Salvador

            if (ciudadOrigen == "San Salvador" && ciudadDestino == "Buenos Aires")
            {
                tarifa = 230.00;
                duracionVuelo = 8.0; // Duración en horas
            }
            else if (ciudadOrigen == "San Salvador" && ciudadDestino == "Nueva York")
            {
                tarifa = 400.00;
                duracionVuelo = 5.0;
            }
            else if (ciudadOrigen == "San Salvador" && ciudadDestino == "Tokio")
            {
                tarifa = 650.00;
                duracionVuelo = 14.0;
            }
            else if (ciudadOrigen == "San Salvador" && ciudadDestino == "Sidney")
            {
                tarifa = 500.00;
                duracionVuelo = 16.0;
            }
            else if (ciudadOrigen == "San Salvador" && ciudadDestino == "Berlin")
            {
                tarifa = 550.00;
                duracionVuelo = 10.0;
            }
            else if (ciudadOrigen == "San Salvador" && ciudadDestino == "Londres")
            {
                tarifa = 460.00;
                duracionVuelo = 9.5;
            }
            else if (ciudadOrigen == "San Salvador" && ciudadDestino == "Amsterdam")
            {
                tarifa = 360.00;
                duracionVuelo = 9.0;
            }
            else if (ciudadOrigen == "San Salvador" && ciudadDestino == "Dubai")
            {
                tarifa = 650.00;
                duracionVuelo = 12.0;
            }

            // Guatemala
            else if (ciudadOrigen == "Ciudad de Guatemala" && ciudadDestino == "Korea")
            {
                tarifa = 560.00;
                duracionVuelo = 15.0;
            }
            else if (ciudadOrigen == "Ciudad de Guatemala" && ciudadDestino == "Nueva York")
            {
                tarifa = 550.00;
                duracionVuelo = 4.5;
            }
            else if (ciudadOrigen == "Ciudad de Guatemala" && ciudadDestino == "Tokio")
            {
                tarifa = 500.00;
                duracionVuelo = 13.5;
            }
            else if (ciudadOrigen == "Ciudad de Guatemala" && ciudadDestino == "Sidney")
            {
                tarifa = 530.00;
                duracionVuelo = 17.0;
            }
            else if (ciudadOrigen == "Ciudad de Guatemala" && ciudadDestino == "Berlin")
            {
                tarifa = 600.00;
                duracionVuelo = 10.5;
            }
            else if (ciudadOrigen == "Ciudad de Guatemala" && ciudadDestino == "Londres")
            {
                tarifa = 4500.00;
                duracionVuelo = 9.5;
            }
            else if (ciudadOrigen == "Ciudad de Guatemala" && ciudadDestino == "Amsterdam")
            {
                tarifa = 360.00;
                duracionVuelo = 9.0;
            }

            // Toronto
            else if (ciudadOrigen == "Toronto" && ciudadDestino == "Sidney")
            {
                tarifa = 250.00;
                duracionVuelo = 20.0;
            }
            else if (ciudadOrigen == "Toronto" && ciudadDestino == "Berlin")
            {
                tarifa = 300.00;
                duracionVuelo = 8.5;
            }
            else if (ciudadOrigen == "Toronto" && ciudadDestino == "Londres")
            {
                tarifa = 260.00;
                duracionVuelo = 7.5;
            }
            else if (ciudadOrigen == "Toronto" && ciudadDestino == "Amsterdam")
            {
                tarifa = 340.00;
                duracionVuelo = 7.8;
            }
            else if (ciudadOrigen == "Toronto" && ciudadDestino == "Korea")
            {
                tarifa = 560.00;
                duracionVuelo = 14.5;
            }
            else if (ciudadOrigen == "Toronto" && ciudadDestino == "Nueva York")
            {
                tarifa = 260.00;
                duracionVuelo = 1.5;
            }
            else if (ciudadOrigen == "Toronto" && ciudadDestino == "Tokio")
            {
                tarifa = 550.00;
                duracionVuelo = 13.0;
            }
            else if (ciudadOrigen == "Toronto" && ciudadDestino == "Dubai")
            {
                tarifa = 555.00;
                duracionVuelo = 12.5;
            }

            // Brasil
            else if (ciudadOrigen == "Sao Paulo" && ciudadDestino == "Berlin")
            {
                tarifa = 660.00;
                duracionVuelo = 12.0;
            }
            else if (ciudadOrigen == "Sao Paulo" && ciudadDestino == "Londres")
            {
                tarifa = 550.00;
                duracionVuelo = 11.0;
            }
            else if (ciudadOrigen == "Sao Paulo" && ciudadDestino == "Amsterdam")
            {
                tarifa = 450.00;
                duracionVuelo = 11.5;
            }
            else if (ciudadOrigen == "Sao Paulo" && ciudadDestino == "Korea")
            {
                tarifa = 570.00;
                duracionVuelo = 20.0;
            }
            else if (ciudadOrigen == "Sao Paulo" && ciudadDestino == "Nueva York")
            {
                tarifa = 400.00;
                duracionVuelo = 10.5;
            }
            else if (ciudadOrigen == "Sao Paulo" && ciudadDestino == "Tokio")
            {
                tarifa = 650.00;
                duracionVuelo = 18.0;
            }
            else if (ciudadOrigen == "Sao Paulo" && ciudadDestino == "Dubai")
            {
                tarifa = 690.00;
                duracionVuelo = 16.5;
            }
            else if (ciudadOrigen == "Sao Paulo" && ciudadDestino == "Sidney")
            {
                tarifa = 350.00;
                duracionVuelo = 13.5;
            }


            // México
            else if (ciudadOrigen == "Ciudad de Mexico" && ciudadDestino == "Sidney")
            {
                tarifa = 750.00;
                duracionVuelo = 18.0; // Duración en horas
            }
            else if (ciudadOrigen == "Ciudad de Mexico" && ciudadDestino == "Berlin")
            {
                tarifa = 680.00;
                duracionVuelo = 12.5;
            }
            else if (ciudadOrigen == "Ciudad de Mexico" && ciudadDestino == "Londres")
            {
                tarifa = 700.00;
                duracionVuelo = 10.0;
            }
            else if (ciudadOrigen == "Ciudad de Mexico" && ciudadDestino == "Amsterdam")
            {
                tarifa = 620.00;
                duracionVuelo = 9.5;
            }
            else if (ciudadOrigen == "Ciudad de Mexico" && ciudadDestino == "Korea")
            {
                tarifa = 770.00;
                duracionVuelo = 14.5;
            }
            else if (ciudadOrigen == "Ciudad de Mexico" && ciudadDestino == "Nueva York")
            {
                tarifa = 500.00;
                duracionVuelo = 4.0;
            }
            else if (ciudadOrigen == "Ciudad de Mexico" && ciudadDestino == "Tokio")
            {
                tarifa = 720.00;
                duracionVuelo = 13.5;
            }
            else if (ciudadOrigen == "Ciudad de Mexico" && ciudadDestino == "Dubai")
            {
                tarifa = 800.00;
                duracionVuelo = 15.0;
            }

            // Costa Rica
            else if (ciudadOrigen == "San Jose" && ciudadDestino == "Sidney")
            {
                tarifa = 750.00;
                duracionVuelo = 19.0;
            }
            else if (ciudadOrigen == "San Jose" && ciudadDestino == "Berlin")
            {
                tarifa = 680.00;
                duracionVuelo = 13.0;
            }
            else if (ciudadOrigen == "San Jose" && ciudadDestino == "Londres")
            {
                tarifa = 710.00;
                duracionVuelo = 11.5;
            }
            else if (ciudadOrigen == "San Jose" && ciudadDestino == "Amsterdam")
            {
                tarifa = 500.00;
                duracionVuelo = 9.0;
            }
            else if (ciudadOrigen == "San Jose" && ciudadDestino == "Korea")
            {
                tarifa = 760.00;
                duracionVuelo = 16.0;
            }
            else if (ciudadOrigen == "San Jose" && ciudadDestino == "Nueva York")
            {
                tarifa = 540.00;
                duracionVuelo = 5.0;
            }
            else if (ciudadOrigen == "San Jose" && ciudadDestino == "Tokio")
            {
                tarifa = 730.00;
                duracionVuelo = 14.0;
            }
            else if (ciudadOrigen == "San Jose" && ciudadDestino == "Dubai")
            {
                tarifa = 790.00;
                duracionVuelo = 16.5;
            }

            // Belice (Belmopan)
            else if (ciudadOrigen == "Belmopan" && ciudadDestino == "Sidney")
            {
                tarifa = 770.00;
                duracionVuelo = 20.0;
            }
            else if (ciudadOrigen == "Belmopan" && ciudadDestino == "Berlin")
            {
                tarifa = 690.00;
                duracionVuelo = 13.5;
            }
            else if (ciudadOrigen == "Belmopan" && ciudadDestino == "Londres")
            {
                tarifa = 720.00;
                duracionVuelo = 11.0;
            }
            else if (ciudadOrigen == "Belmopan" && ciudadDestino == "Amsterdam")
            {
                tarifa = 630.00;
                duracionVuelo = 9.5;
            }
            else if (ciudadOrigen == "Belmopan" && ciudadDestino == "Korea")
            {
                tarifa = 780.00;
                duracionVuelo = 17.0;
            }
            else if (ciudadOrigen == "Belmopan" && ciudadDestino == "Nueva York")
            {
                tarifa = 510.00;
                duracionVuelo = 3.5;
            }
            else if (ciudadOrigen == "Belmopan" && ciudadDestino == "Tokio")
            {
                tarifa = 740.00;
                duracionVuelo = 15.0;
            }
            else if (ciudadOrigen == "Belmopan" && ciudadDestino == "Dubai")
            {
                tarifa = 600.00;
                duracionVuelo = 12.5;
            }


            //mensaje de no hay tarifa en el labeltext de tarifa

            else
            {
                labelTarifaCalculada.Text = "No hay una tarifa establecida para esta ruta.";
                return;
            }

            // Modificar tarifa dependiendo del tipo de avión
            if (tipoAvion == "Boeing 77")
            {
                tarifa += 50.00;
            }
            else if (tipoAvion == "Airbus A32")
            {
                tarifa += 100.00;
            }
            else if (tipoAvion == "Embraer E17")
            {
                tarifa += 75.00;
            }

            // Modificar tarifa dependiendo de la aerolínea
            if (aerolinea == "American Airlines")
            {
                tarifa += 20.00;
            }
            else if (aerolinea == "Delta Air Lines")
            {
                tarifa += 30.00;
            }
            else if (aerolinea == "Air France")
            {
                tarifa += 40.00;
            }

            // Mostrar la tarifa y duración en el Label
            if (tarifa == 0 || duracionVuelo == 0)
            {
                MessageBox.Show("No se encontraron vuelos para la combinación seleccionada.");
            }
            else
            {
                labelTarifaCalculada.Text = $"El vuelo de {ciudadOrigen} a {ciudadDestino} tiene un costo de ${tarifa} y una duración de {duracionVuelo} horas.";
                // Obtener el total a pagar acumulado desde la base de datos y sumarlo a la tarifa calculada
                double totalPagarBD = ObtenerTotalPagarDesdeBD();
                double montoTotal = tarifa + totalPagarBD;

                // Mostrar el monto total en un Label
                labelTotalapagar.Text = $"Monto total a pagar acumulado: ${montoTotal}";
            }


        }
        private double ObtenerTotalPagarDesdeBD()
        {
            string connectionString = "server=localhost;database=aerolinea;user=root;password=1234;";
            double totalPagar = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener la suma del campo total_pagar en la tabla reservas
                    string query = "SELECT SUM(total_pagar) FROM reservas";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        totalPagar = result != DBNull.Value ? Convert.ToDouble(result) : 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el total de pagar: {ex.Message}");
                }
            }

            return totalPagar;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //text de buscar vuelo 
            string searchQuery = textBoxBuscar.Text;
            string query = $"SELECT * FROM vuelos WHERE ciudad_origen LIKE '%{searchQuery}%' OR ciudad_destino LIKE '%{searchQuery}%'";

            try
            {
                //abre la conexion 
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            finally
            {
                //cierra la coenxion
                connection.Close();
            }
        }
        //boton de salida del formulario
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

        private bool ValidarCampos()
        {
            // Verifica si los ComboBox tienen algún valor seleccionado
            if (comboBoxCiudadOrigen.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una Ciudad de Origen.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxCiudadDestino.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una Ciudad de Destino.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxTipoAvion.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un Tipo de Avión.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxAerolinea.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una Aerolínea.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Verifica si los DateTimePicker tienen fechas seleccionadas
            if (dateTimePickerSalida.Value == null)
            {
                MessageBox.Show("Por favor, selecciona una Fecha de Salida.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dateTimePickerRetorno.Value == null)
            {
                MessageBox.Show("Por favor, selecciona una Fecha de Retorno.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dateTimePickerSalida.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha seleccionada no puede ser en el pasado.", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dateTimePickerRetorno.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha seleccionada no puede ser en el pasado.", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Verifica si los TextBox tienen algún texto
            if (string.IsNullOrWhiteSpace(textBoxRuta.Text))
            {
                MessageBox.Show("Por favor, ingresa una Ruta.", "Campo Obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true; // Todos los campos están completos
        }

        // Bloquea el teclado en los ComboBox de selección para que solo puedan seleccionar opciones.
        private void comboBoxCiudadOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Impide la escritura en el ComboBox
        }

        private void comboBoxCiudadDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Impide la escritura en el ComboBox
        }
        // Bloquea el teclado en los DateTimePicker para que solo puedan seleccionar la fecha con el control.
        private void dateTimePickerSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Impide la escritura en el DateTimePicker
           
        }

        private void dateTimePickerRetorno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Impide la escritura en el ComboBox
            
        }

        private void comboBoxTipoAvion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Impide la escritura en el ComboBox
        }

        private void comboBoxAerolinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Impide la escritura en el ComboBox
        }
        

        
    }
}
