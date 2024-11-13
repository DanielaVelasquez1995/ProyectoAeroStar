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
    public partial class LoginForm : Form
    {
        private string connectionString = "server=localhost;database=aerolinea;user=root;password=1234;";
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Autores: Alvarado Méndez Oscar Eduardo  - AM22043
        ///          Martínez Hernández Wendy Beatriz - MH22052
        ///          Orellana Velasquez Daniela Estefany - OV22002
        ///          Ramirez Vasquez Nancy Esmeralda - RV24003
        /// Grupo De Trabajo:  Grupo #3
        /// Hora:1:00 p.m
        /// Fecha:26-10-2024
        /// Descripcion:Programa de inisio de seccion para los diferentes roles de este sistema de boletos aereos
        /// <retuns>Este programa retorna un mensaje si el administrador y usuario ingreso correctamente</retuns>
        /// <param txtNombre.Text="">El usuario de la persona</param>
        /// <param txtContraseña.Text="">La contraseña de la persona</param>
        /// 
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

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
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

        // Boton de iniciar sesion del formulario para el usuario
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Variables de entrada (Declaracion y asignacion)
            string nombre = txtNombre.Text;
            string contraseña = txtContraseña.Text;

            // Conexion mysql con los datos de la tabla registro y guarda los datos del usuario
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                //Abre la conexion a la base de datos
                conn.Open();

                //Comando SQL para selccionar el rol de usuario segun su nombre y contraseña
                MySqlCommand cmd = new MySqlCommand("SELECT Rol FROM registro WHERE Nombre = @Nombre AND Contraseña = @Contraseña", conn);

                //Agrega los parametros a la consulta para evitar inyecciones SQL
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                //Ejecuta el comando y almacena el rol devuelto en la variable rol
                var rol = cmd.ExecuteScalar();
                if (rol != null)
                {
                    if (rol.ToString() == "Administrador")
                    {
                        var adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide();
                        // Oculta el formulario de login
                    }
                    else
                    {
                        MessageBox.Show("Login exitoso como usuario.");
                        var userForm = new UserForm();
                        userForm.Show();
                        this.Hide();
                        // Oculta el formulario de login
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas.");
                }

                string nombres = txtNombre.Text;
                string contraseñas = txtContraseña.Text;
                //Validaciones campos vacios de los textboxs del formulario 
                if (string.IsNullOrEmpty(nombres))
                {
                    //Mensaje a reflejar al momento de dejar campo vacio txtNombre
                    MessageBox.Show("El campo Usuario esta vacio", "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (string.IsNullOrEmpty(contraseñas))
                {
                    //Mensaje a reflejar al momento de dejar campo vacio
                    MessageBox.Show("El campo contraseña esta vacio", "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}





