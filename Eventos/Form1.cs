﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = " ";
            timer1.Interval = 3000;
            timer1.Enabled = false;
            timer2.Interval = 2000;
            timer2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.Visible = false;
            timer1.Enabled = false;
            button1.BackColor= Color.Red;
        }

        private void Form1_Shown_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled= true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(rutas[contador]);

            contador++;

            if (contador >= rutas.Length)
            {
                contador = 0;
            }
        }
        private string[] rutas = { "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img1.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img2.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img3.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img4.png", "C:\\Users\\Saul\\source\\repos\\Eventos\\Eventos\\Imagenes\\Img5.png" };
        private int contador = 0;


    }
}