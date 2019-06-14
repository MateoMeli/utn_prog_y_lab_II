﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej._69
{
    public partial class FrmMostrar : Form
    {
        public delegate void ActualizaNombreDelegate(string dato);

        public FrmMostrar()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string dato)
        {
            this.lblEtiqueta.Text = dato;
        }
    }
}
