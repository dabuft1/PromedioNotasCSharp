using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
            float nota1 = float.Parse(txtNota1.Text);
            float nota2 = float.Parse(txtNota2.Text);
            float nota3 = float.Parse(txtNota3.Text);
            float promedio = 0;

            promedio = (nota1 + nota2 + nota3) / 3;

            lblResultado.Text = Convert.ToString(promedio);
        }
    }
}
