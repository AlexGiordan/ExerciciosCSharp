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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void exerciciosComInteiros1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InteirosQuetao1 NovoFormulario = new InteirosQuetao1();
            NovoFormulario.MdiParent = this;
            NovoFormulario.Show();

        }
    }
}
