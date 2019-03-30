using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColaderaDeEratostenes
{
    public partial class Form1 : Form
    {
        ColaderaVector vec = new ColaderaVector();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = vec.Mostrar();
        }

        private void btnColadera_Click(object sender, EventArgs e)
        {
            vec.IniUno();
            vec.Coladera();
        }
    }
}
