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
    public partial class Menu_Principal : Form
    {
        List<Guitarra> listaGuitarras;
        public Menu_Principal()
        {
            InitializeComponent();
            listaGuitarras = new List<Guitarra>();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Guitarra aux;

            Alta_Instrumento frmAlta = new Alta_Instrumento();


            if(frmAlta.ShowDialog() == DialogResult.OK)
            {
                aux = frmAlta.InfoGuitarra;

                listaGuitarras.Add(aux);
                RefrescarListBox();



            }
        }

        private void RefrescarListBox()
        {

            listBox1.DataSource = null;
            listBox1.DataSource = listaGuitarras;

        }



    }
}
