﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_Formulario_JonathanHeleria_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string nombres = txtNombre.Text;
            string apellidos = txtApellido.Text;
            string edad = txtEdad.Text;
            string estatura = txtEstatura.Text;
            string telefono = txtTelefono.Text;

            string genero = "";
            if (RbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (RbMujer.Checked)
            {
                genero = "Mujer";
            }

            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nEdad: {edad} años\r\nEstatura: {estatura} cm\r\nTelefono: {telefono}\r\nGenero: {genero}";

            // Especifica la ruta completa, incluyendo el nombre del archivo
            string rutaArchivo = "C:\\Users\\jonae\\OneDrive\\DatosInfo.txt";

            // Verifica si el archivo existe antes de escribir
            bool archivoExiste = File.Exists(rutaArchivo);

            // Abre el archivo para escritura, en modo adjunto (append)
            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                // No se necesita una verificación adicional, simplemente escribe los datos
                writer.WriteLine(datos);
                writer.WriteLine(); // Añade una línea en blanco después de los datos
            }

            MessageBox.Show("Datos guardados exitosamente.");
        }
    }
    }

