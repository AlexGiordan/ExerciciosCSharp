using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosCSharp
{
    public partial class InteirosQuetao1 : Form
    {
        public InteirosQuetao1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LResultado;
            int LInicio = System.Convert.ToInt32(UpInicio.Value.ToString());
            int LFinal = System.Convert.ToInt32(UpFinal.Value.ToString());

            EdtResultado.Text = "";
            Barra.Maximum = LFinal;
            Barra.Value = LInicio;

            while (LInicio <= LFinal)
            {
                LResultado = System.Convert.ToInt32(Math.Pow(System.Convert.ToDouble(LInicio), System.Convert.ToDouble(2)));
                Barra.Value = LInicio;
                EdtResultado.AppendText("O quadrado de " + System.Convert.ToString(LInicio) + " é " + System.Convert.ToString(LResultado) + Environment.NewLine);
                LInicio += 1;
            }
        }
    }
}
