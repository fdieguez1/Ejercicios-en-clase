﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace Clase_07_UI_2
{
    public partial class Form1 : Form
    {
        Guitarra guitarra1;
        Guitarra guitarra2;
        Cliente cliente1;
        Cliente cliente2;

        public Form1()
        {
            InitializeComponent();

            guitarra1 = new Guitarra(EMarca.Gibson, "Les Paul", 550000);
            guitarra2 = new Guitarra(EMarca.Fender, "Strato", 550000);

            cliente1 = new Cliente("Pepe", guitarra1);
            cliente2 = new Cliente("Juana", guitarra2);


        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {

            this.txt_nombreCliente.Text = cliente1.Nombre;

            if (cliente1.Instrumento != null)
            {
                this.txt_info.Text = cliente1.Instrumento.Precio.ToString();
            }
            else
            {
                this.txt_info.Text = "Instrumento aun no comprado";

            }

        }
    }
}
