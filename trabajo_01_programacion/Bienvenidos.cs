using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_01_programacion
{
    public partial class Bienvenidos : Form
    {
        public Bienvenidos()
        {
            InitializeComponent();
        }

        private void Enter01_Click(object sender, EventArgs e)
        {
            Form program_descrip = new program_descrip();
            program_descrip.Show();
         }

        private void accion_iniciar_Click(object sender, EventArgs e)
        {
            Form Inicio = new Inicio();
            Inicio.Show();
        }
    }
}
