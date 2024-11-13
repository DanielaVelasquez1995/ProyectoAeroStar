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
    /// Descripcion:Programa de inisio de seccion para los diferentes roles de este sistema de boletos aereos
    /// <retuns>Este programa retorna un mensaje si el administrador y usuario ingreso correctamente</retuns>
    /// <param txtNombre.Text="">El usuario de la persona</param>
    /// <param txtContraseña.Text="">La contraseña de la persona</param>
    public partial class Form1 : Form
    {

        //cadena de conexion de mysql con el nombre de la base de datos, el usuario y contraseña
        private string connectionString = "server=localhost;database= aerolinea;user=root;password=1234;";


        public Form1()
        {
           
            InitializeComponent();
            // roles de los usuarios del registro
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Usuario");
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // variables de entrada 
            string nombre = txtNombre.Text;
            string contraseña = txtContraseña.Text;
            string rol = cmbRol.SelectedItem != null ? cmbRol.SelectedItem.ToString() : "";
           
            if (cmbRol.SelectedItem != null)
            {
                rol = cmbRol.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un rol.");
                return;
            }

            // conexion mysql con los datos de la tabla registro y guarda los datos del usuario
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO registro (Nombre, Contraseña, Rol) VALUES (@Nombre, @Contraseña, @Rol)", conn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                cmd.Parameters.AddWithValue("@Rol", rol);

                try
                {
                    //mensaje de registro existoso para el usuario
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro exitoso");

                    // Cierra el formulario de registro
                    this.Close();

                    // Abre el formulario de inicio de sesión
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                catch (Exception ex)
                {
                    // mensaje de error por si hay falla 
                    MessageBox.Show("Error: " + ex.Message);
                }

                //Validaciones campos vacios de los textboxs del formulario

                

                if (string.IsNullOrEmpty(nombre))
                {
                    //Mensaje a reflejar al momento de dejar campo vacio
                    MessageBox.Show("El campo usuario esta vacio", "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (string.IsNullOrEmpty(contraseña))
                {
                    //Mensaje a reflejar al momento de dejar campo vacio
                    MessageBox.Show("El campo contraseña esta vacio", "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }


        private void btnIrLogin_Click(object sender, EventArgs e)
        {
            // Abre el formulario de login
         
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void txtNombre_keyPress(object sender, KeyPressEventArgs e)
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
      }
}


