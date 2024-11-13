using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; //Se agregan bibliotecas necesarias 
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AerolineaForms
{
    public partial class UserForm : Form
    {
        private MySqlConnection conexion; // se declara la conexión a la base de datos MySQL

        public UserForm()
        {
            InitializeComponent();
            InicializarConexion();  // llama al método que incia la conexión con la base de datos
            CargarDatos();          // llama al método que llena los datos al DataGridView
        }
        // método para inicializar la conexión con la base de datos MySQL
        private void InicializarConexion()
        {
            // la conexión con los parámetros necesarios para conectarse a la BD MySql
            string cadenaConexion = "Server=localhost;Database=aerolinea;User ID=root;Password=1234;SslMode=none;";
            conexion = new MySqlConnection(cadenaConexion);  // se crea una instancia de MySqlConnection con la cadena de conexión
        }
        // método para cargar los datos de la tabla en el DataGridView
        private void CargarDatos()
        {
            try
            {
                // verifica si la conexión está cerrada antes de abrirla
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();  // abre la conexión si está cerrada
                }

                // consulta SQL para obtener todos los registros de la tabla `usuario`
                string consulta = "SELECT * FROM usuarios";
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion); // crea un adaptador de datos con la consulta y la conexión
                DataTable dt = new DataTable();  // crea una tabla en memoria para almacenar los datos
                adapter.Fill(dt);  // llena la tabla con los datos obtenidos de la consulta
                dataGridViewUser.DataSource = dt;  // asigna la tabla como fuente de datos del DataGridView para mostrar los registros
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
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                //Mensaje a reflejar
                MessageBox.Show("Solo se permiten letras", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void dtpFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir teclas de control (como retroceso)
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Permitir dígitos y caracteres específicos para la fecha
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != ':' && e.KeyChar != ' ')
            {
                MessageBox.Show("Solo se permiten números, '/', ':' y espacios.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void txtNumeroPasaporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si el texto ya tiene 7 caracteres y se intenta ingresar un nuevo carácter (que no sea Backspace), lo bloqueamos
            if (txtNumeroPasaporte.Text.Length >= 7 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancelamos la entrada
                return; // Salimos del evento, no procesamos más nada
            }

            // Validación para permitir solo números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Mostrar un mensaje si no es un número
                MessageBox.Show("Solo se permiten números", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true; // Cancelamos la entrada del carácter no numérico
            }

        }

        private void txtPreferenciaAsiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si el texto ya tiene una longitud de 3 caracteres (ejemplo "A12"), no permitimos más entradas (excepto Backspace)
            if (txtPreferenciaAsiento.Text.Length >= 3 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancelamos la entrada
                return;
            }

            // Permitimos solo letras (mayúsculas) en la primera posición
            if (txtPreferenciaAsiento.Text.Length == 0 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Cancelamos la entrada si no es una letra
                MessageBox.Show("El primer carácter debe ser una letra (A-Z).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Permitimos solo números en la segunda y tercera posición
            if (txtPreferenciaAsiento.Text.Length == 1 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelamos la entrada si no es un número
                MessageBox.Show("El segundo carácter debe ser un número (1-99).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Permitimos solo números en la segunda o tercera posición si el primer carácter es una letra
            if (txtPreferenciaAsiento.Text.Length == 2 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelamos la entrada si no es un número
                MessageBox.Show("El tercer carácter debe ser un número (1-99).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string numeroPasaporte = txtNumeroPasaporte.Text;
            string preferenciaAsiento = txtPreferenciaAsiento.Text;

            // Validaciones
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(numeroPasaporte) || string.IsNullOrWhiteSpace(preferenciaAsiento))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El campo 'Nombre' solo debe contener letras.");
                return;
            }

            if (!Regex.IsMatch(numeroPasaporte, @"^\d+$"))
            {
                MessageBox.Show("El campo 'Número de Pasaporte' solo debe contener números.");
                return;
            }

            // Cálculo de la edad
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
            {
                edad--; // Ajuste si el cumpleaños no ha pasado este año
            }

            // Validación de edad mínima
            if (edad < 18)
            {
                MessageBox.Show("Debes tener al menos 18 años para ser registrado.", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Abre la conexión a la base de datos
                conexion.Open();

                // Verifica si la preferencia de asiento ya está ocupada
                string checkAsientoQuery = "SELECT COUNT(*) FROM usuarios WHERE preferencia_asiento = @preferencia_asiento";
                MySqlCommand checkAsientoCmd = new MySqlCommand(checkAsientoQuery, conexion);
                checkAsientoCmd.Parameters.AddWithValue("@preferencia_asiento", preferenciaAsiento);
                int count = Convert.ToInt32(checkAsientoCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("La preferencia de asiento ya está ocupada. Por favor, seleccione otro asiento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Consulta SQL para insertar un nuevo registro en la tabla usuarios
                string query = "INSERT INTO usuarios (nombre, fecha_nacimiento, numero_pasaporte, preferencia_asiento) " +
                               "VALUES (@nombre, @fecha_nacimiento, @numero_pasaporte, @preferencia_asiento)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);

                // Agrega los valores a los parámetros de la consulta
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                cmd.Parameters.AddWithValue("@numero_pasaporte", numeroPasaporte);
                cmd.Parameters.AddWithValue("@preferencia_asiento", preferenciaAsiento);

                // Ejecuta la consulta para insertar el registro
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pasajero agregado correctamente.");

                // Actualiza el DataGridView para mostrar el nuevo registro
                CargarDatos();
            }
            catch (Exception ex)
            {
                // Muestra un mensaje en caso de error
                MessageBox.Show("Error al agregar el usuario: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión a la base de datos
                conexion.Close();
            }
        }

        private void btnRcalculo_Click(object sender, EventArgs e)
        {
            Calculo calculo = new Calculo();
            this.Hide();
            calculo.ShowDialog();
            this.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtNombre.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now; // Establece la fecha actual
            txtNumeroPasaporte.Text = "";
            txtPreferenciaAsiento.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // muestra un cuadro de diálogo de confirmación antes de cerrar la aplicación
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)  // si el usuario selecciona "Sí", se cierra la aplicación
            {
                Application.Exit();
            }
        }
    }
}
