﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej0011
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        public Cliente MiCliente;
        private void Form1_Load(object sender, EventArgs e)
        {
            MiCliente = new Cliente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiCliente.Nombre = this.textBox1.Text;
            MiCliente.Apellido = this.textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Nombre es: " + this.textBox1.Text + "\r\nEl Apellido es: " + this.textBox2.Text);
        }
    }
    public class Cliente

    {
        string VNombre = "";
        public string Nombre
        {
            get { return this.VNombre; }
            protected set { this.VNombre = value; }
        }
        public string Apellido { get; set; }
    }
}
