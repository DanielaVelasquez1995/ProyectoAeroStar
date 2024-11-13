using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AerolineaForms
{
    public partial class AdminForm : Form
    {
        /// <summary>
        /// Autores: Alvarado Méndez Oscar Eduardo  - AM22043
        ///          Martínez Hernández Wendy Beatriz - MH22052
        ///          Orellana Velasquez Daniela Estefany - OV22002
        ///          Ramirez Vasquez Nancy Esmeralda - RV24003
        /// Grupo De Trabajo:  Grupo #3
        /// Hora:1:00 p.m
        /// Fecha:26-10-2024
        /// Descripcion:Programa de inisio de seccion para los diferentes roles de este sistema de boletos aereos
        ///  Variables de entrada textboxs del formulario txtNombre.Text ,dtpFechaNacimiento,txtNumeroPasaporte,txtPreferenciaAsiento
        private MySqlConnection conexion;

        public AdminForm()
        {
            InitializeComponent();
            conexion = new MySqlConnection("server=localhost;database=aerolinea;uid=root;pwd=1234;");
            CargarDatosUsuarios();
        }
        //Función para cargar datos en el DataGridView
        private void CargarDatosUsuarios()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;database=aerolinea;uid=root;pwd=1234;"))
                {
                    conexion.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM usuarios", conexion);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewUsuarios.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }


        }


        //boton añadir para el usuario 
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            List<string> errores = ValidarCampos();
            if (errores.Count > 0)
            {
                string mensajeErrores = string.Join("\n", errores);
                MessageBox.Show(mensajeErrores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;database=aerolinea;uid=root;pwd=1234;"))
                {
                    conexion.Open();

                    // Verificar si la preferencia de asiento ya está ocupada
                    string checkAsientoQuery = "SELECT COUNT(*) FROM usuarios WHERE preferencia_asiento = @preferencia_asiento";
                    MySqlCommand checkAsientoCmd = new MySqlCommand(checkAsientoQuery, conexion);
                    checkAsientoCmd.Parameters.AddWithValue("@preferencia_asiento", txtPreferenciaAsiento.Text);
                    int count = Convert.ToInt32(checkAsientoCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("La preferencia de asiento ya está ocupada. Por favor, seleccione otro asiento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insertar el usuario si el asiento está disponible
                    string insertQuery = "INSERT INTO usuarios (nombre, fecha_nacimiento, numero_pasaporte, preferencia_asiento) " +
                                         "VALUES (@nombre, @fecha_nacimiento, @numero_pasaporte, @preferencia_asiento)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conexion);
                    insertCmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    insertCmd.Parameters.AddWithValue("@fecha_nacimiento", dtpFechaNacimiento.Value);
                    insertCmd.Parameters.AddWithValue("@numero_pasaporte", txtNumeroPasaporte.Text);
                    insertCmd.Parameters.AddWithValue("@preferencia_asiento", txtPreferenciaAsiento.Text);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario añadido correctamente.");
                    CargarDatosUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir usuario: " + ex.Message);
            }
        }
        //boton de modificar usuarios por medio de id 
        private void btnModificar_Click(object sender, EventArgs e)
        {
            List<string> errores = ValidarCampos();
            if (errores.Count > 0)
            {
                string mensajeErrores = string.Join("\n", errores);
                MessageBox.Show(mensajeErrores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;database=aerolinea;uid=root;pwd=1234;"))
                {
                    conexion.Open();

                    // Verificar si la preferencia de asiento ya está ocupada por otro usuario (excluyendo el usuario actual)
                    string checkAsientoQuery = "SELECT COUNT(*) FROM usuarios WHERE preferencia_asiento = @preferencia_asiento AND id != @id";
                    MySqlCommand checkAsientoCmd = new MySqlCommand(checkAsientoQuery, conexion);
                    checkAsientoCmd.Parameters.AddWithValue("@preferencia_asiento", txtPreferenciaAsiento.Text);
                    checkAsientoCmd.Parameters.AddWithValue("@id", txtId.Text);
                    int count = Convert.ToInt32(checkAsientoCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("La preferencia de asiento ya está ocupada. Por favor, seleccione otro asiento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Actualizar el usuario si el asiento está disponible
                    string updateQuery = "UPDATE usuarios SET nombre=@nombre, fecha_nacimiento=@fecha_nacimiento, " +
                                         "numero_pasaporte=@numero_pasaporte, preferencia_asiento=@preferencia_asiento " +
                                         "WHERE id=@id";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conexion);
                    updateCmd.Parameters.AddWithValue("@id", txtId.Text);
                    updateCmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    updateCmd.Parameters.AddWithValue("@fecha_nacimiento", dtpFechaNacimiento.Value);
                    updateCmd.Parameters.AddWithValue("@numero_pasaporte", txtNumeroPasaporte.Text);
                    updateCmd.Parameters.AddWithValue("@preferencia_asiento", txtPreferenciaAsiento.Text);

                    updateCmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario modificado correctamente.");
                    CargarDatosUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.Message);
            }
        }
        // Evento para cargar datos en los campos al hacer clic en una fila del DataGridView
        private void dataGridViewUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(dataGridViewUsuarios.Rows[e.RowIndex].Cells[2].Value);
            txtNumeroPasaporte.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPreferenciaAsiento.Text = dataGridViewUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        //validaciones de campos vacios
        private List<string> ValidarCampos()
        {
            List<string> errores = new List<string>();

            // Verificar TextBoxes requeridos
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                errores.Add("El campo 'Nombre' debe ser completado.");

            if (string.IsNullOrWhiteSpace(txtNumeroPasaporte.Text))
                errores.Add("El campo 'Número de Pasaporte' debe ser completado.");

            if (string.IsNullOrWhiteSpace(txtPreferenciaAsiento.Text))
                errores.Add("El campo 'Preferencia de Asiento' debe ser completado.");

            // Validar que el nombre contenga solo letras y espacios
            if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z\s]+$"))
                errores.Add("El campo 'Nombre' solo debe contener letras y espacios.");

            // Validar que el número de pasaporte contenga solo dígitos
            if (!Regex.IsMatch(txtNumeroPasaporte.Text, @"^\d+$"))
                errores.Add("El campo 'Número de Pasaporte' solo debe contener números.");

            // Validación de edad mínima de 18 años
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
            {
                edad--; // Ajuste si el cumpleaños no ha pasado este año
            }
            if (edad < 18)
            {
                errores.Add("El usuario debe tener al menos 18 años.");
            }

            return errores; // Retornar lista de errores
        }

        // Botón Consultar para buscar usuarios por nombre
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID para realizar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;database=aerolinea;uid=root;pwd=1234;"))
                {
                    string query = "SELECT * FROM usuarios WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    conexion.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Mostrar los datos encontrados en los campos correspondientes
                        txtNombre.Text = reader["nombre"].ToString();
                        dtpFechaNacimiento.Value = Convert.ToDateTime(reader["fecha_nacimiento"]);
                        txtNumeroPasaporte.Text = reader["numero_pasaporte"].ToString();
                        txtPreferenciaAsiento.Text = reader["preferencia_asiento"].ToString();
                        MessageBox.Show("Usuario encontrado.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario con el ID proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar usuario: " + ex.Message);
            }

        }
          
    

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            List<string> errores = ValidarCampos();
            if (errores.Count > 0)
            {
                // Unir todos los mensajes de error en un solo string
                string mensajeErrores = string.Join("\n", errores);
                MessageBox.Show(mensajeErrores, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Si hay errores, no continuar
            }
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;database=aerolinea;uid=root;pwd=1234;"))
                {
                    string query = "DELETE FROM usuarios WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    //mensaje de eliminado el usuario
                    MessageBox.Show("Usuario eliminado correctamente.");
                    //funcion de cargar datos del usuario
                    CargarDatosUsuarios();
                }
            }
            catch (Exception ex)
            {
                //mensaje de error de eliminacion de usuario
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }


        }
        //validaciones de entrada de los textboxs del formulario
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

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //Mensaje a reflejar
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
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
    }
}
